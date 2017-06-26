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
using Restaurant.GridView;
using Services;

namespace Restaurant
{
    public partial class Products : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ProductService _productService;
        private readonly ProductGridView _productGrid;
        
        public Products()
        {
            InitializeComponent();
            _uow = new Context();
            _productService = new ProductService(_uow);
            _productGrid = new ProductGridView(dgvProducts);
            ShowProducts();
            cmbProductType.DataSource = Enum.GetValues(typeof(ProductType));

        }
        //نشان دادن کلیه محصولات
        private void ShowProducts()
        {
            dgvProducts.Rows.Clear();
            _productService.GetProducts().ForEach(x=>
            {
                _productGrid.Add(x.Name, x.Description, x.Price,x.Type);
            });
        }

        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            if (txtProductName.Text.Trim() == "" ||
                txtProductPrice.Text.Trim() == ""||
                cmbProductType.SelectedValue == null)
            {
                MessageBox.Show("اطلاعات وارد شده صحیح نیست.");
                return;
                
            }
            double d = 0;
            if (!double.TryParse(txtProductPrice.Text, out d))
            {
                MessageBox.Show("مشکلی رخ داد. دوباره تلاش کنید.");
                return;
            }

            if (_productService.HasNameExists(txtProductName.Text))
            {
                MessageBox.Show("محصولی با این نام وجود دارد. نام دیگری را وارد نمایید.");
                return;
            }

            _productService.Add(new Product()
            {
                Available =  true,
                Description = txtProductDesc.Text,
                Name = txtProductName.Text,
                Price = d,
                Type = (ProductType)cmbProductType.SelectedValue
            });
            _uow.SaveChanges();
            ShowProducts();
            ClearTextBoxes();
        }
        //پاک کردن اطلاعات وارد شده پس از اضافه شدن محصول
        private void ClearTextBoxes()
        {
            foreach (var txt in Controls.OfType<TextBox>())
            {
                txt.Text = "";
            }
            
        }
        //بازگشت به صفحه اصلی
        private void retrunHome_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() != "" ||
                txtProductPrice.Text.Trim() != "")
            {

                if (MessageBox.Show("اطلاعات کامل نشده اند. مایل به کنار گذاشتن آن دارید؟","هشدار",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Service.ChangeForm(new Main(), this);
            }
            else
            {
                Service.ChangeForm(new Main(), this);
            }
        }
    }
}
