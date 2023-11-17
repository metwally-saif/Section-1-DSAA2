using Section_1_DSAA2.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section_1_DSAA2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var departments = CompanyDataGenerator.GenerateCompanyStructure();

            Form1 mainForm = new Form1(departments);
            Application.Run(mainForm);
        }
    }
}
