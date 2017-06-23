using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DomainClasses;
using Services;

namespace Restaurant
{
    public partial class Order : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ProductService _productService;
        private readonly FactorService _factorService;
        private readonly FactorDetailService _factorDetailService;
        private readonly DomainClasses.Restaurant _restaurant = DomainClasses.Restaurant.GetCurrent();
        private List<FactorDetail> factorsDetails;
        public Order()
        {
            _uow = new Context();
            _productService = new ProductService(_uow);
            _factorService = new FactorService(_uow);
            factorsDetails = new List<FactorDetail>();
            _factorDetailService = new FactorDetailService(_uow);
            InitializeComponent();
            InitializeDataGridView();            
        }



        private void InitializeDataGridView()
        {
            var combo = dgvFactorDetails.Columns[0] as DataGridViewComboBoxColumn;
            combo.DataSource = _productService.GetAvailableProductNames();
        }

        private int GetCountValue(int row)
        {
            int count = 1;
            bool valid = false;
            valid = int.TryParse(dgvFactorDetails[1, row].Value.ToString(), out count) && count != 0;
            if (valid)
                return count;
            MessageBox.Show("تعداد وارد شده صحیح نمی باشد. دوباره سعی کنید");
            return 1;
        }

        private void UpdateTotalPrice()
        {
            double total = 0;
            for (int i = 0;i<dgvFactorDetails.Rows.Count;i++)
            {
                object obj = dgvFactorDetails.Rows[i].Cells[4].Value ?? 0;
                total += double.Parse(obj.ToString());
            }
            txtTotalPrice.Text = total.ToString();
            int tax = _restaurant.Tax;
            txtTotalPriceWithTax.Text = (total + total * tax / 100).ToString();
        }
        private void dgvFactorDetails_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void dgvFactorDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //نمیدونم چرا همون دفعه اول با اضافه کردن هر ستون یکبار اجرا می شود
            if (e.RowIndex == -1)
                return;
            if (e.ColumnIndex == 1)
            {
                int count = GetCountValue(e.RowIndex<0?0:e.RowIndex);
                string name = dgvFactorDetails[0, e.RowIndex].Value.ToString();
                double price = _productService.GetPriceByName(name);
                dgvFactorDetails[4, e.RowIndex].Value = price;
                double total = price * count;
                dgvFactorDetails[4, e.RowIndex].Value = total;
            }
            else if (e.ColumnIndex == 4 )
                UpdateTotalPrice();
            else if (e.ColumnIndex == 0)
            {
                dgvFactorDetails[1, e.RowIndex].Value = 1;
            }
        }
        //برای بررسی رویداد های کمبو باکس ، نیاز به این کد داریم. انها پیش فرض اجرا نمی شوند
        private void dgvFactorDetails_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            
            dgvFactorDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Factor factor = new Factor()
            {
                Date = DateTime.Now,
                //FactorDetails = _factorDetailService.GetFactorDetails(),
                TotalPrice = double.Parse(txtTotalPrice.Text),
                TotalPriceWithTax = double.Parse(txtTotalPriceWithTax.Text)
            };            
            foreach (DataGridViewRow current in dgvFactorDetails.Rows)
            {
                if (current.Cells[0].Value == null)
                    continue;
                var f = new FactorDetail()
                {
                    Count = int.Parse(current.Cells[1].Value.ToString()),
                    Description = current.Cells[2].Value?.ToString() ?? "",
                    ProductId = _productService.GetIdByName(current.Cells[0].Value.ToString()),
                    Factor = factor,
                    TotalPrice = double.Parse(current.Cells[4].Value.ToString())
                };
                factorsDetails.Add(f);
                _factorDetailService.Add(f);
            }
            factor.FactorDetails = factorsDetails;
            _factorService.Add(factor);
            _uow.SaveChanges();





            new Main().Show();
            this.Close();
        }

        private void dgvFactorDetails_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }
    }
}
