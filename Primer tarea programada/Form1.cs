using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_tarea_programada
{
    public partial class Form1 : Form
    {
        int filas = 0, columnas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFilas.Text.Length == 0 | txtColumnas.Text.Length == 0)
            {
                Console.WriteLine("Debe ingresar ambos valores para generar la matriz");
            }
            else
            {
                bool rows = int.TryParse(txtFilas.Text, out filas);
                bool columns = int.TryParse(txtColumnas.Text, out columnas);

                if (!rows | !columns) // si es true (eran solo numeros)
                {
                    Console.WriteLine("Debe ingresar solamente numeros.\n");
                }
                else
                {
                    if ((filas <= 5 & columnas <= 5) & (filas > 0 & columnas > 0))
                    {
                        int[,] array = new int[filas, columnas];
                        Console.WriteLine("Matriz creada de manera exitosa");
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar numeros mayores o iguales a 1 y menores o iguales a 5");
                    }
                }
            }
            
        }
    }
}
