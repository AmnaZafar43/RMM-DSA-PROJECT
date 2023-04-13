using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMM
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
            DL.accountDL.getFromFile();
            DL.productDL.getFromFile();
            DL.riderDL.getFromFile();
            DL.shopkeeperDL.getFromFile();
            DL.employeeDL.getFromFile();
            DL.placeOrderDL.getFromFile();
            Application.Run(new Login());
            
        }
    }
}
