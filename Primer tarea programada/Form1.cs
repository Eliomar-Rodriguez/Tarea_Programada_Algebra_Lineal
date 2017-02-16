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
        /// <summary>
        /// lista que contiene las 3 matrices (a, b, c)
        /// </summary>
        List<List<List<TextBox>>> ListaMatrices = new List<List<List<TextBox>>>();

        List<List<int>> dimensiones=new List<List<int>>();

        public Form1()
        {
            InitializeComponent();
            CmbMatriz.SelectedIndex = 0;
            CmbMatriz.Update();
            CmbFilas.SelectedIndex = 0;
            CmbFilas.Update();
            CmbColumn.SelectedIndex = 0;
            CmbColumn.Update();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 3; x++)
            {
                ListaMatrices.Add(new List<List<System.Windows.Forms.TextBox>>());
                for (int y = 0; y < 5; y++)
                {
                    ListaMatrices[x].Add(new List<System.Windows.Forms.TextBox>());
                }
            }
            // matriz a
            ListaMatrices[0][0].Add(a11);
            ListaMatrices[0][0].Add(a12);
            ListaMatrices[0][0].Add(a13);
            ListaMatrices[0][0].Add(a14);
            ListaMatrices[0][0].Add(a15);

            ListaMatrices[0][1].Add(a21);
            ListaMatrices[0][1].Add(a22);
            ListaMatrices[0][1].Add(a23);
            ListaMatrices[0][1].Add(a24);
            ListaMatrices[0][1].Add(a25);

            ListaMatrices[0][2].Add(a31);
            ListaMatrices[0][2].Add(a32);
            ListaMatrices[0][2].Add(a33);
            ListaMatrices[0][2].Add(a34);
            ListaMatrices[0][2].Add(a35);

            ListaMatrices[0][3].Add(a41);
            ListaMatrices[0][3].Add(a42);
            ListaMatrices[0][3].Add(a43);
            ListaMatrices[0][3].Add(a44);
            ListaMatrices[0][3].Add(a45);

            ListaMatrices[0][4].Add(a51);
            ListaMatrices[0][4].Add(a52);
            ListaMatrices[0][4].Add(a53);
            ListaMatrices[0][4].Add(a54);
            ListaMatrices[0][4].Add(a55);

            // matriz b

            ListaMatrices[1][0].Add(b11);
            ListaMatrices[1][0].Add(b12);
            ListaMatrices[1][0].Add(b13);
            ListaMatrices[1][0].Add(b14);
            ListaMatrices[1][0].Add(b15);

            ListaMatrices[1][1].Add(b21);
            ListaMatrices[1][1].Add(b22);
            ListaMatrices[1][1].Add(b23);
            ListaMatrices[1][1].Add(b24);
            ListaMatrices[1][1].Add(b25);
       
            ListaMatrices[1][2].Add(b31);
            ListaMatrices[1][2].Add(b32);
            ListaMatrices[1][2].Add(b33);
            ListaMatrices[1][2].Add(b34);
            ListaMatrices[1][2].Add(b35);
        
            ListaMatrices[1][3].Add(b41);
            ListaMatrices[1][3].Add(b42);
            ListaMatrices[1][3].Add(b43);
            ListaMatrices[1][3].Add(b44);
            ListaMatrices[1][3].Add(b45);
        
            ListaMatrices[1][4].Add(b51);
            ListaMatrices[1][4].Add(b52);
            ListaMatrices[1][4].Add(b53);
            ListaMatrices[1][4].Add(b54);
            ListaMatrices[1][4].Add(b55);
        
        }
    

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        
        /// <summary>
        /// Función encargada de poner false en la propiedad visible de todas las cajas de la matriz 5x5 que se pueden trabajar
        /// </summary>
        void OcultarCajas(int matriz)
        {
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    ListaMatrices[matriz][f][c].Visible = false;                        
                }
            }
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            
            /*// validacion de campos vacios
            for(int i = 0; i < 2; i++)
            {
                for (int f = 0; f < filas; f++)
                {
                    for (int c = 0; c < columnas; c++)
                    {
                        if (ListaMatrices[i][f][c].Text.Length == 0) // si algun campo no tiene nada escrito
                        {
                            lbl1.Visible = true;
                            lbl2.Visible = true;
                            lbl3.Visible = true;
                            break;
                        }
                    }
                }
            }

            for (int f = 0; f < filas; f++)
            {
                for(int c = 0; c < columnas; c++)
                {
                    matrizA[f,c] = int.Parse(ListaMatrices[0][f][c].Text);
                }
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CmbMatriz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Boton que genera (crea) la matriz
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            OcultarCajas(CmbMatriz.SelectedIndex);
            for(int x = 0; x <= CmbFilas.SelectedIndex; x++)
            {
                for (int y = 0; y <= CmbColumn.SelectedIndex; y++)
                {
                    ListaMatrices[CmbMatriz.SelectedIndex][x][y].Visible = true;
                }
            }
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
