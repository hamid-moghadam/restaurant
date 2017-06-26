using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainClasses.Enums;

namespace Restaurant.GridView
{
    public class ProductGridView:CustomGridView, ICustomColumn
    {

        public ProductGridView(DataGridView grid):base(grid)
        {
            _grid.Columns.AddRange(GenerateColumns());

        }
        public DataGridViewColumn[] GenerateColumns()
        {
            DataGridViewColumn[] columns = new[]
            {
                new DataGridViewTextBoxColumn() { HeaderText = "نام محصول"},
                new DataGridViewTextBoxColumn() { HeaderText= "توضیحات"},
                new DataGridViewTextBoxColumn() { HeaderText= "قیمت"},
                new DataGridViewTextBoxColumn() { HeaderText = "نوع محصول"},
            };
            return columns;
        }

        public void Add(string name, string desc, double price, ProductType type)
        {
            _grid.Rows.Add(name, desc, $"{price:c0}", type);
        }
    }
}
