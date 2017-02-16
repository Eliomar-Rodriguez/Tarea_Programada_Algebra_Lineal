using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.
namespace Primer_tarea_programada
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
            Application.Run(new Form1());
            List<List<List<System.Windows.Forms.TextBox>>> ListaMatrices = new List<List<List<System.Windows.Forms.TextBox>>>();
            for (int x = 0; x < 3; x++)
            {
                ListaMatrices.Add(new List<List<System.Windows.Forms.TextBox>>());
                for (int y = 0; y < 5; y++)
                {
                    ListaMatrices[x].Add(new List<System.Windows.Forms.TextBox>());
                }
            }
            string hola;
            
        }
    }
}
