using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DM_CT_PROJECT_59251__59087_
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
            Application.Run(new SelectionForm());
        }
    }
}
