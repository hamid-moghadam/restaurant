using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainClasses.Enums;

namespace Restaurant.GridView
{
    public class AvailableProductGridView: CustomGridView, ICustomColumn
    {
        public AvailableProductGridView(DataGridView grid) : base(grid)
        {
            _grid.Columns.AddRange(GenerateColumns());
        }

        public DataGridViewColumn[] GenerateColumns()
        {
            DataGridViewColumn[] columns =
            {
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "نام محصول",
                },
                new DataGridViewTextBoxColumn() {HeaderText = "قیمت", ReadOnly = true},
                new DataGridViewTextBoxColumn() {HeaderText = "نوع محصول", ReadOnly = true},
                new DataGridViewButtonColumn()
                {
                    HeaderText = "موجود",
                    Text = "حذف از منو باز",
                    UseColumnTextForButtonValue = true
                },
            };
            return columns;
        }

        public void Add(string name, double price, ProductType type)
        {
            _grid.Rows.Add(name, $"{price:c0}", type);
        }
    }
}
