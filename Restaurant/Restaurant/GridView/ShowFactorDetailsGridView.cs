using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.GridView
{
    public class ShowFactorDetailsGridView: CustomGridView, ICustomColumn
    {
        public ShowFactorDetailsGridView(DataGridView grid) : base(grid)
        {
            _grid.Columns.AddRange(GenerateColumns());
        }

        public DataGridViewColumn[] GenerateColumns()
        {
            DataGridViewColumn[] columns =
            {
                new DataGridViewTextBoxColumn() {HeaderText = "نام محصول"},
                new DataGridViewTextBoxColumn() {HeaderText = "قیمت"},
                new DataGridViewTextBoxColumn() {HeaderText = "تعداد"}
            };
            return columns;
            
        }

        public void Add(string name, double price, int count)
        {
            _grid.Rows.Add(name, $"{price:c0}", count);
        }
    }
}
