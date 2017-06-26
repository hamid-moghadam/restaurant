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
using Restaurant.GridView;
using Services;

namespace Restaurant
{
    public partial class Order : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ProductService _productService;
        private readonly FactorService _factorService;
        private readonly FactorDetailService _factorDetailService;
        private readonly FactorDetailsGridView _orderGrid;



        public Order()
        {
            InitializeComponent();
            _uow = new Context();
            _productService = new ProductService(_uow);
            _factorService = new FactorService(_uow);
            _factorDetailService = new FactorDetailService(_uow);
            _orderGrid = new FactorDetailsGridView(dgvFactorDetails);

        }
        /// <summary>
        /// بررسی صحیح بودن فیلد تعداد و بازگرداندن آن
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
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
        /// <summary>
        /// نشان دادن مجموع کل قیمت به همراه مالیات
        /// </summary>
        private void UpdateTotalPrice()
        {
            double total = 0;
            for (int i = 0;i<dgvFactorDetails.Rows.Count;i++)
            {
                object obj = dgvFactorDetails.Rows[i].Cells[4].Value ?? 0;
                total += double.Parse(obj.ToString());
            }
            txtTotalPrice.Text = $"{total:c0}";
            int tax = Service.GetCurrentRestaurant().Tax;
            txtTotalPriceWithTax.Text = $"{(total + total * tax / 100):c0}";
        }
        //تغییر قیمت کل با حذف هر سفارش توسط کاربر
        private void dgvFactorDetails_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void dgvFactorDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //مشکل: دفعه اول با اضافه کردن هر ستون یکبار اجرا می شود
            if (e.RowIndex == -1)
                return;
            //تغییر تعداد
            if (e.ColumnIndex == 1)
            {
                UpdateProductPrice(e.RowIndex);
                UpdateTotalPrice();

            }
            //تغییر قیمت کل فاکتور ها
            else if (e.ColumnIndex == 4 )
                UpdateTotalPrice();
            //تغییر نام محصول
            else if (e.ColumnIndex == 0)
            {
                dgvFactorDetails[1, e.RowIndex].Value = 1;
                UpdateProductPrice(e.RowIndex);
                UpdateTotalPrice();
            }
        }
        //تغییر مجموع قیمت در صورت تغییر تعداد
        private void UpdateProductPrice(int rowIndex)
        {
            int count = GetCountValue(rowIndex < 0 ? 0 : rowIndex);
            string name = dgvFactorDetails[0, rowIndex].Value.ToString();
            double price = _productService.GetPriceByName(name);
            dgvFactorDetails[3, rowIndex].Value = price;
            double total = price * count;
            dgvFactorDetails[4, rowIndex].Value = total;
        }

        //برای بررسی رویداد های کمبو باکس ، نیاز به این کد داریم. انها پیش فرض اجرا نمی شوند
        private void dgvFactorDetails_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvFactorDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        //ثبت تمامی سفارشات
        private void submit_Click(object sender, EventArgs e)
        {
            if (dgvFactorDetails.Rows.Count == 0)
            {
                Service.ChangeForm(new Main(), this);
                return;
            }
            Factor factor = new Factor()
            {
                Date = DateTime.Now,
                TotalPrice = double.Parse(txtTotalPrice.Text.Replace(".","").Replace("$","")),
                TotalPriceWithTax = double.Parse(txtTotalPriceWithTax.Text.Replace(".", "").Replace("$", ""))
            };            
            _factorService.Add(factor);
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
                _factorDetailService.Add(f);
            }
            _uow.SaveChanges();
            Service.ChangeForm(new Main(),this);
        }

        private void retrunHome_Click(object sender, EventArgs e)
        {
            Service.ChangeForm(new Main(), this);
        }
    }
}
