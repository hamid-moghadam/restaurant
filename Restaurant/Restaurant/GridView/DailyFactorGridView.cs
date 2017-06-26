using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.GridView
{
    public class DailyFactorGridView: CustomGridView, ICustomColumn

    {
        public DailyFactorGridView(DataGridView grid) : base(grid)
        {
            _grid.Columns.AddRange(GenerateColumns());
        }

        public DataGridViewColumn[] GenerateColumns()
        {
            DataGridViewColumn[] columns =
            {
                new DataGridViewTextBoxColumn() {Visible = false},
                new DataGridViewTextBoxColumn() {HeaderText = "تاریخ"},
                new DataGridViewTextBoxColumn() {HeaderText = "مجموع قیمت"},
                new DataGridViewButtonColumn()
                {
                    HeaderText = "ریز فاکتور",
                    Text = "مشاهده سفارشات",
                    UseColumnTextForButtonValue = true
                }
            };
            return columns;

        }

        public void Add(int id, DateTime d, double totalPrice)
        {
            PersianCalendar pc = new PersianCalendar();
            _grid.Rows.Add(id, Service.ToPersionDate(d), $"{totalPrice:c0}");
        }
    }
}
