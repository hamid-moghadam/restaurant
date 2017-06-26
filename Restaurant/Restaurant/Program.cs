using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form first = null;
            if (File.Exists(Directory.GetCurrentDirectory() + "\\info.txt"))
                first = new SignIn();
            else
                first = new SignUp();
            Application.Run(first);
        }
    }
}
