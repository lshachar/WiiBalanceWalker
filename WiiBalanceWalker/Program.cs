using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WiiBalanceWalker
{
    static class BalanceWalker
    {
        public static FormMain FormMain;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain = new FormMain();
            Application.Run(FormMain);
        }
    }
}
