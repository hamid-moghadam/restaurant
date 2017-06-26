using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.GridView
{
    public class FactorGridView:CustomGridView,ICustomColumn
    {
        public FactorGridView(DataGridView grid) :base(grid)
        {
            _grid.Columns.AddRange(GenerateColumns());
        }

        public DataGridViewColumn[] GenerateColumns()
        {
            DataGridViewColumn[] columns = 
            {
                new DataGridViewTextBoxColumn() { HeaderText = "شماره محصول",Visible = false},
                new DataGridViewTextBoxColumn() { HeaderText = "مجموع قیمت"},
                new DataGridViewTextBoxColumn() { HeaderText = "تاریخ"},
                new DataGridViewButtonColumn() { HeaderText = "ریز فاکتور",Text = "مشاهده سفارشات",UseColumnTextForButtonValue = true},
                new DataGridViewButtonColumn(){ HeaderText = "حذف",Text = "حذف فاکتور",UseColumnTextForButtonValue = true}
            };
            return columns;
        }


        public void Add(int id, double totalPrice, DateTime d)
        {

            _grid.Rows.Add(id, $"{totalPrice:c0}", Service.ToPersionDate(d));
        }

    }
}
