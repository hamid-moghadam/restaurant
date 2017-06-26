using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        public static string ToPersionDate(DateTime d)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(d)}/{pc.GetMonth(d)}/{pc.GetDayOfMonth(d)}";
        }

        public static DomainClasses.Restaurant GetCurrentRestaurant()
        {
            string path = Directory.GetCurrentDirectory() + "\\info.txt";
            string[] info = File.ReadAllLines(path);
            DomainClasses.Restaurant r;
            using (FileStream stream = File.OpenRead(path))
            {
                var formatter = new BinaryFormatter();
                r = (DomainClasses.Restaurant)formatter.Deserialize(stream);
            }
            return r;
        }


    }
}
