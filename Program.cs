using CoffeeManagement.pdf;
using CoffeeManagement.qrCode;
using System;
using System.Windows.Forms;

using CoffeeManagement.management;
using CoffeeManagement.context;
using CoffeeManagement.UI;

namespace CoffeeManagement
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
            mainFrm = new Main();
            Application.Run(new Login());
        }

        public static CoffeeManagementContext context = new CoffeeManagementContext();
        public static Main mainFrm;
    }
}
