using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forms = System.Windows.Forms;

namespace LGroup.ControleFinanceiro.UI.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Forms.Application.EnableVisualStyles();
            Forms.Application.SetCompatibleTextRenderingDefault(false);
            Forms.Application.Run(new Views.RecebimentoView());
        }
    }
}
