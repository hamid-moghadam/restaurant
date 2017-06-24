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
using DomainClasses.Enums;
using Services;

namespace Restaurant
{
    public partial class Main : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ProductService _productService;
        private readonly FactorService _factorService;
        private readonly FactorDetailService _factorDetailService;
        private readonly DomainClasses.Restaurant _restaurant = DomainClasses.Restaurant.GetCurrent();
        public Main()
        {
            _uow = new Context();
            _productService = new ProductService(_uow);
            _factorService = new FactorService(_uow);
            _factorDetailService = new FactorDetailService(_uow);
            InitializeComponent();
            InitializeFactorsGridView();
            InitializeProductsGridView();
            comboBox1.DataSource = _productService.GetUnAvailableProductNames();
            //ShowProducts();
            ShowFactors();
        }



        private void ShowProducts()
        {
            //var availablePro = _productService.GetAvailableProducts();
            //availablePro.ForEach(x=> { dgvAvailableProduct.Rows.Add(x.Name, x.Price, x.Type); });
            //Service.HideColumns(dgvAvailableProduct,"Id", "Description", "Available", "FactorDetails");
        }

        private void ShowFactors()
        {
            IUnitOfWork uow = new Context();
            var productService = new FactorService(uow);
            var factors  = productService.GetFactorsByDate(DateTime.Today);
            factors.ForEach(x=> { dgvFactors.Rows.Add(x.Id,$"{x.TotalPriceWithTax:c0}", x.Date.ToShortDateString()); });
            
            //Service.HideColumns(dgvFactors, "Id");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service.ChangeForm(new Order(),this);
        }

        private void InitializeFactorsGridView()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Visible = false;
            DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            date.HeaderText = "تاریخ";
            DataGridViewTextBoxColumn totalPrice = new DataGridViewTextBoxColumn();
            totalPrice.HeaderText = "مجموع قیمت";
            DataGridViewButtonColumn showFactorDetail = new DataGridViewButtonColumn();
            showFactorDetail.HeaderText = "ریز فاکتور";
            showFactorDetail.Text = "مشاهده سفارشات";
            showFactorDetail.UseColumnTextForButtonValue = true;
            dgvFactors.Columns.Add(id);
            dgvFactors.Columns.Add(totalPrice);
            dgvFactors.Columns.Add(date);
            dgvFactors.Columns.Add(showFactorDetail);
            
        }

        private void InitializeProductsGridView()
        {
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn
            {
                HeaderText = "نام محصول",
            };
            DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
            price.HeaderText = "قیمت";
            price.ReadOnly = true;
            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            type.HeaderText = "نوع محصول";
            type.ReadOnly = true;
            DataGridViewButtonColumn available = new DataGridViewButtonColumn();
            available.HeaderText = "موجود";
            available.Text = "حذف از منو باز";
            available.UseColumnTextForButtonValue = true;
            dgvAvailableProduct.Columns.Add(name);
            dgvAvailableProduct.Columns.Add(price);
            dgvAvailableProduct.Columns.Add(type);
            dgvAvailableProduct.Columns.Add(available);
            
            _productService.GetProducts().ForEach(x =>
            {
                //DataGridViewRow row = new DataGridViewRow {Visible = true};
                if (x.Available)
                {
                    //row.SetValues(x.Id, x.Name, x.Price, x.Type);
                    dgvAvailableProduct.Rows.Add(x.Name, x.Price, x.Type);
                }
            });
        }

        private void dgvFactors_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 3) return;
            var factor = _factorService.GetDetailsById(int.Parse(dgvFactors[0, e.RowIndex].Value.ToString()));
            Form info = new Form();
            DataGridView grid = new DataGridView();
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            name.HeaderText = "نام محصول";
            DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
            price.HeaderText = "قیمت";
            DataGridViewTextBoxColumn count = new DataGridViewTextBoxColumn();
            count.HeaderText = "تعداد";
            grid.Columns.Add(name);
            grid.Columns.Add(count);
            grid.Columns.Add(price);
            //پروداکت اتوماتیک پر نمی شد
            factor.ForEach(x => { grid.Rows.Add(_productService.GetById(x.ProductId).Name, x.Count,x.TotalPrice); });
            info.Controls.Add(grid);
            grid.Dock = DockStyle.Fill;
            Service.ResizeColumns(grid);
            info.ShowDialog();
        }

        private void dgvAvailableProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 1)
            //{
            //    var product = _productService.GetByName(dgvAvailableProduct[1, e.RowIndex].Value.ToString());
            //    //dgvAvailableProduct.Rows.Add(x.Name, x.Price, x.Type);
            //    dgvAvailableProduct[2, e.RowIndex].Value = product.Price;
            //    dgvAvailableProduct[3, e.RowIndex].Value = product.Type;
            //    product.Available = true;
            //    _uow.SaveChanges();
            //    (dgvAvailableProduct.Columns[0] as DataGridViewComboBoxColumn).DataSource = _productService
            //        .GetUnAvailableProductNames();
            //}
        }

        private void dgvAvailableProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var product = _productService.GetByName(dgvAvailableProduct[0, e.RowIndex].Value.ToString());
                //اولین سطر در صورت پر نبودن خطا صادر می کنه
                    dgvAvailableProduct.Rows.RemoveAt(e.RowIndex);
                    product.Available = false;
                    _uow.SaveChanges();
                //حالا میخوام عدم موجود بودن محصول رو ذخیره کنم. چطوری؟؟؟
            }
        }

        private void dgvAvailableProduct_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvAvailableProduct.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            comboBox1.DataSource = _productService.GetUnAvailableProductNames();
        }

        private void btnAddProductToMenu_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("محصولی برای اضافه کردن وجود ندارد");
                return;
            }
            //با فرض اینکه نام محصول یونیک باشد
            var product = _productService.GetByName(comboBox1.SelectedValue.ToString());
            if (product == null || product.Available)
                return;
            dgvAvailableProduct.Rows.Add(product.Name, product.Price, product.Type);
            product.Available = true;
            _uow.SaveChanges();
            // comboBox1.DataSource = _productService.GetUnAvailableProductNames();
            //حالا میخوام موجود بودن محصول رو ذخیره کنم. چطوری؟؟؟
        }
    }
}
