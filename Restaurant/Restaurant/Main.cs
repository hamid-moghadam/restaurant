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
        public Main()
        {
           
            InitializeComponent();
            ShowProducts();
            ShowFactors();
        }



        private void ShowProducts()
        {
            IUnitOfWork uow = new Context();
            var productService = new ProductService(uow);
            var source = new BindingSource { DataSource = productService.GetAvailableProducts() };
            
            dgvAvailableProduct.DataSource = source.DataSource;
            dgvAvailableProduct.Columns["Id"].Visible = false;
            dgvAvailableProduct.Columns["Description"].Visible = false;
            dgvAvailableProduct.Columns["Available"].Visible = false;
            dgvAvailableProduct.Columns["FactorDetails"].Visible = false;
        }

        private void ShowFactors()
        {
            IUnitOfWork uow = new Context();
            var productService = new FactorService(uow);
            var source = new BindingSource { DataSource = productService.GetFactorsByDate(DateTime.Today) };
            dgvAvailableProduct.DataSource = source.DataSource;
        }
    }
}
