using System;
using System.Windows.Forms;
using DAL;
using Restaurant.GridView;
using Services;

namespace Restaurant
{
    public partial class Main : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ProductService _productService;
        private readonly FactorService _factorService;
        private readonly DailyFactorGridView _dailyFactors;
        private readonly AvailableProductGridView _availableProducts;

        public Main()
        {
            InitializeComponent();
            _uow = new Context();
            _productService = new ProductService(_uow);
            _factorService = new FactorService(_uow);
            _dailyFactors = new DailyFactorGridView(dgvFactors);
            _availableProducts = new AvailableProductGridView(dgvAvailableProduct);
            comboBox1.DataSource = _productService.GetUnAvailableProductNames();
            Text = Service.GetCurrentRestaurant().Name;
            ShowProducts();
            ShowFactors();
        }


        private void ShowFactors()
        {
            var factors  = _factorService.GetFactorsByDate(DateTime.Today);
            factors.ForEach(x=> { _dailyFactors.Add(x.Id, x.Date,x.TotalPriceWithTax); });
        }

        private void ShowProducts()
        {
            _productService.GetAvailableProducts().ForEach(x =>
            {
                _availableProducts.Add(x.Name, x.Price, x.Type);
            });
        }

        private void dgvFactors_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 3 || dgvFactors[0, e.RowIndex].Value == null) return;
            var factor = _factorService.GetDetailsById(int.Parse(dgvFactors[0, e.RowIndex].Value.ToString()));
            #region ایجد فرم جدید برای نمایش جزئیات فاکتور
            Form info = new Form();
            DataGridView grid = new DataGridView();
            ShowFactorDetailsGridView orders = new ShowFactorDetailsGridView(grid);
            //پروداکت اتوماتیک پر نمی شد
            factor.ForEach(x => { orders.Add(_productService.GetById(x.ProductId).Name, x.TotalPrice,x.Count); });
            info.Controls.Add(grid);
            grid.Dock = DockStyle.Fill;
            Service.ResizeColumns(grid);
            info.ShowDialog();
            #endregion
        }

        private void dgvAvailableProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //بررسی کلیک شدن دکمه حذف از منو باز
            if (e.ColumnIndex == 3)
            {
                if (dgvAvailableProduct[0, e.RowIndex].Value == null)
                    return;
                var product = _productService.GetByName(dgvAvailableProduct[0, e.RowIndex].Value.ToString());
                //اولین سطر در صورت پر نبودن خطا صادر می کنه
                    dgvAvailableProduct.Rows.RemoveAt(e.RowIndex);
                    product.Available = false;
                    _uow.SaveChanges();
            }
        }

        private void dgvAvailableProduct_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //اجرا شدن رویداد کلیک برای کمبوباکس
            dgvAvailableProduct.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //نمایش محصولاتی که موجود نیستند
            comboBox1.DataSource = _productService.GetUnAvailableProductNames();
        }

        private void btnAddProductToMenu_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("محصولی برای اضافه کردن وجود ندارد");
                return;
            }
            AddProductToMenu();
            comboBox1.Text = "";
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Service.ChangeForm(new Products(), this);
        }
        /// <summary>
        /// اضافه کردن محصول به منو باز
        /// </summary>
        private void AddProductToMenu()
        {
            var product = _productService.GetByName(comboBox1.SelectedValue.ToString());
            if (product == null || product.Available)
                return;
            _availableProducts.Add(product.Name, product.Price, product.Type);
            product.Available = true;
            _uow.SaveChanges();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Service.ChangeForm(new Order(), this);
        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            Service.ChangeForm(new Factors(), this);
        }
    }
}
