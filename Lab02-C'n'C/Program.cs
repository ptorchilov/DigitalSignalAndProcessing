using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab02_C_n_C
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
            Application.Run(new ApplicationForm());
        }
    }
}
