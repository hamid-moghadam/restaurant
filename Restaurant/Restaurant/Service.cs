using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Services;

namespace Restaurant
{
    public static class Service
    {
        public static void ChangeForm(Form openForm, Form closeForm)
        {
            closeForm.Hide();
            openForm.ShowDialog();
            closeForm.Close();
        }

        public static void HideColumns(DataGridView grid, params string[] columnNames)
        {
            foreach (string t in columnNames)
            {
                if (grid.Columns[t] != null)
                    grid.Columns[t].Visible = false;
            }
        }


        public static void ResizeColumns(DataGridView dgv)
        {
            // Resize the master DataGridView columns to fit the newly loaded data.
            dgv.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }
        


    }
}
