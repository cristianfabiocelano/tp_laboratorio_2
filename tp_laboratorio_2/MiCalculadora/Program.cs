using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LaCalculadora formulario = new LaCalculadora();
            formulario.FormBorderStyle = FormBorderStyle.FixedSingle;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.MinimizeBox = false;
            formulario.MaximizeBox = false;
            Application.Run(formulario);
           
            
        }
    }
}
