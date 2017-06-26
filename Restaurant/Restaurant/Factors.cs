using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DAL;
using DomainClasses;
using Extensions;
using Restaurant.GridView;
using Services;

namespace Restaurant
{
    public partial class Factors : Form
    {

        private readonly IUnitOfWork _uow;
        private readonly FactorService _factorService;
        private readonly ProductService _productService;
        private readonly FactorGridView _factorGrid;

        public Factors()
        {
            InitializeComponent();
            _uow = new Context();
            _factorService = new FactorService(_uow);
            _productService = new ProductService(_uow);
            _factorGrid = new FactorGridView(dgvFactors);
            ShowFactors();
        }

        private void ShowFactors()
        {
            dgvFactors.Rows.Clear();
            _factorService.GetFactors().ForEach(x=> { _factorGrid.Add(x.Id, x.TotalPriceWithTax, x.Date); });
            txtTotalPrice.Text = $"{_factorService.GetTotalPrice():c0}";
            txtTotalPriceWithTax.Text = $"{_factorService.GetTotalPriceWithTax():c0}";
        }

        private void ShowFactors(List<Factor> factors)
        {
            dgvFactors.Rows.Clear();
            factors.ForEach(x => { _factorGrid.Add(x.Id, x.TotalPriceWithTax, x.Date); });
            txtTotalPrice.Text = $"{factors.Sum(x => x.TotalPrice)}";
            txtTotalPriceWithTax.Text = $"{factors.Sum(x => x.TotalPriceWithTax)}";
        }
        private void dgvFactors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //بررسی دکمه حذف
            if (e.ColumnIndex == 4 && dgvFactors[0, e.RowIndex].Value != null)
            {
                DeleteFactor(e.RowIndex);
            }
            //بررسی دکمه مشاهده سفارشات
            else if (e.ColumnIndex == 3 && dgvFactors[0, e.RowIndex].Value != null)
            {
                if (dgvFactors[0, e.RowIndex].Value == null)
                    return;
                var id = int.Parse(dgvFactors[0, e.RowIndex].Value.ToString());
                ShowFactorDetail(id);
            }
        }

        //حذف فاکتور بر اساس سطر امتخاب شده
        private void DeleteFactor(int rowIndex)
        {
            _factorService.RemoveById(int.Parse(dgvFactors[0, rowIndex].Value.ToString()));
            dgvFactors.Rows.RemoveAt(rowIndex);
            _uow.SaveChanges();
            ShowFactors();
        }

        //نمایش تمامی محصولات فاکتور مربوطه
        private void ShowFactorDetail(int id)
        {
            var details = _factorService.GetDetailsById(id);
            Form info = new Form();
            DataGridView grid = new DataGridView();
            ShowFactorDetailsGridView orders = new ShowFactorDetailsGridView(grid);
            //پروداکت اتوماتیک پر نمی شد
            details.ForEach(x => { orders.Add(_productService.GetById(x.ProductId).Name, x.TotalPrice,x.Count ); });
            info.Controls.Add(grid);
            grid.Dock = DockStyle.Fill;
            Service.ResizeColumns(grid);
            info.ShowDialog();
        }
        //بازگشت به صفحه اصلی
        private void retrunHome_Click(object sender, EventArgs e)
        {
            Service.ChangeForm(new Main(), this);
        }
        //تبدیل به پی دی اف (بدلیل عدم داشتن وقت کافی تکمیل نشد) 
        private void toPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DataGridView v = new DataGridView();

                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dgvFactors.Columns)
                {
                    if (col.GetType() == typeof(DataGridViewTextBoxColumn))
                        dt.Columns.Add(col.HeaderText);
                }
                foreach (DataGridViewRow row in dgvFactors.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //if (cell.GetType() == typeof(DataGridViewTextBoxColumn))
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dRow);
                }
                PDFConverter pdf = new PDFConverter(sfd.FileName, dt);
                pdf.Generate(_factorService.GetFactors());
            }
        }
        //اعمال فیلتر بر اساس تاریخ
        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            string end = txtEndDate.Text;
            string start = txtStartDate.Text;
            if (!IsPersionDate(end) || !IsPersionDate(start))
            {
                MessageBox.Show("تاریخ وارد شده صحیح نمی باشد");
                return;
            }
            string[] startDate = txtStartDate.Text.Split('/');
            PersianCalendar pc = new PersianCalendar();
            DateTime startD = new DateTime(int.Parse(startDate[0]), int.Parse(startDate[1]), int.Parse(startDate[2]), pc);
            string[] endDate = txtEndDate.Text.Split('/');
            DateTime endD = new DateTime(int.Parse(endDate[0]), int.Parse(endDate[1]), int.Parse(endDate[2]), pc);
            var filterd = _factorService.FilterByDate(startD, endD);
            ShowFactors(filterd);
        }
        //بررسی صحت تاریخ از ورودی
        private bool IsPersionDate(string date)
        {
            string[] format = date.Split('/');
            if (format.Length != 3)
                return false;
            foreach (string seprator in format)
            {
                foreach (char c in seprator)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }
            }
            if (format[0].Length != 4)
                return false;
            for (int i = 1; i < format.Length; i++)
            {
                if (format[i].Length <= 0 || format[i].Length >= 3)
                    return false;
            }
            return true;

        }
        //حذف فیلتر
        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            ShowFactors();
            txtEndDate.Text = "";
            txtStartDate.Text = "";
        }

        private void txtStartDate_Click(object sender, EventArgs e)
        {
            txtStartDate.SelectAll();
        }

        private void txtEndDate_Click(object sender, EventArgs e)
        {
            txtEndDate.SelectAll();

        }
    }
}
