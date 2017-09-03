using System;
using System.Windows.Forms;
using Condominio.DeskTop.Formularios.Login;

namespace Condominio.DeskTop
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
            //Application.Run(new FrmMaster());
            Application.Run(new FrmLogin());
        }
    }
}
