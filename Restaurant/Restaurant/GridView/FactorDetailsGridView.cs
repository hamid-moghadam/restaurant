using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Services;

namespace Restaurant.GridView
{
    public class FactorDetailsGridView: CustomGridView, ICustomColumn
    {
        public FactorDetailsGridView(DataGridView grid):base(grid)
        {
            _grid.Columns.AddRange(GenerateColumns());
        }
        public DataGridViewColumn[] GenerateColumns()
        {
            DataGridViewColumn[] columns =
            {
                new DataGridViewComboBoxColumn
                {
                    HeaderText = "نام محصول",
                    DataSource = new ProductService(new Context()).GetAvailableProductNames()
                },
                new DataGridViewTextBoxColumn() {HeaderText = "تعداد"},
                new DataGridViewTextBoxColumn() {HeaderText = "توضیحات"},
                new DataGridViewTextBoxColumn() {HeaderText = "قیمت پایه" , ReadOnly = true},
                new DataGridViewTextBoxColumn() {HeaderText = "مجموع قیمت", ReadOnly = true},
                
            };
            return columns;
        }

        public void Add(int count, string desc, double mainPrice, double totalPrice)
        {
            _grid.Rows.Add(count, desc, mainPrice, totalPrice);
        }
    }
}
