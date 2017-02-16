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
        /// <summary>
        /// Matriz logica en donde se guardan los numeros que son ingresados a la matrz visual (cajas de texto)
        /// </summary>
        List<List<List<int>>> matrizLog = new List<List<List<int>>>();

        List<List<int>> dimensiones = new List<List<int>>();


        public Form1()
        {
            InitializeComponent();
            CmbMatriz.SelectedIndex = 0;
            CmbMatriz.Update();
            CmbFilas.SelectedIndex = 0;
            CmbFilas.Update();
            CmbColumn.SelectedIndex = 0;
            CmbColumn.Update();
            dimensiones.Add(new List<int>());
            dimensiones.Add(new List<int>());
            dimensiones[0].Add(0);
            dimensiones[0].Add(0);
            dimensiones[1].Add(0);
            dimensiones[1].Add(0);

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
            for (int x = 0; x < 3; x++)
            {
                matrizLog.Add(new List<List<int>>());
                for (int y = 0; y < 5; y++)
                {
                    matrizLog[x].Add(new List<int>());
                    for (int z = 0; z < 5; z++)
                    {
                        matrizLog[x][y].Add(0);
                    }
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
            guardarDatos(CmbMatriz.SelectedIndex, CmbFilas.SelectedIndex, CmbColumn.SelectedIndex);
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

        private void transpuesta(int matriz)
        {
            int aux = 0;
            for(int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    aux = matrizLog[matriz][x][y];
                    matrizLog[matriz][x][y] = matrizLog[matriz][y][x];
                    matrizLog[matriz][y][x] = aux;
                    ListaMatrices[matriz][x][y].Text = matrizLog[matriz][x][y].ToString();
                    ListaMatrices[matriz][y][x].Text = matrizLog[matriz][y][x].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardarDatos(CmbMatriz.SelectedIndex, CmbFilas.SelectedIndex, CmbColumn.SelectedIndex);
            transpuesta(CmbMatriz.SelectedIndex);
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

        private void limpmatLog(int x)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int z = 0; z < 5; z++)
                {
                    matrizLog[x][y][z] = 0;
                }
            }
        }

        private void cambiodim(int x, int y, int z)
        {
            for (int a = 0; a <= y; a++)
            {
                for (int b = 0; b <= z; b++)
                {
                    if (!ListaMatrices[x][a][b].Visible)
                        ListaMatrices[x][a][b].Text = "";
                    if (a <= y && b <= z)
                    {
                        ListaMatrices[x][a][b].Visible = true;
                    }
                    else
                    {
                        ListaMatrices[x][a][b].Visible = false;
                    }
                }
            }
            dimensiones[x][0] = y;
            dimensiones[x][1] = z;
            if (dimensiones[0][0] == dimensiones[1][0] && dimensiones[0][1] == dimensiones[1][1])
            {
                radioResta.Enabled = true;
                radioSuma.Enabled = true;
            }
            else
            {
                radioResta.Checked = false;
                radioSuma.Checked = false;
                radioResta.Enabled = false;
                radioSuma.Enabled = false;
            }
            if (dimensiones[0][1] == dimensiones[1][0])
            {
                radioMulti.Enabled = true;
            }
            else
            {
                radioMulti.Checked = false;
                radioMulti.Enabled = false;
            }
        }
        /// <summary>
        /// Boton que genera (crea) la matriz
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            cambiodim(CmbMatriz.SelectedIndex, CmbFilas.SelectedIndex, CmbColumn.SelectedIndex);
        }

        private void negativo(int x, int f, int c)
        {
            /*codigo de alberth
             for(int y=0; y <= dimensiones[x][0]; y++)
            {
                for(int z = 0; z <= dimensiones[x][1]; z++)
                {
                    matrizLog[x][y][z] = matrizLog[x][y][z] * -1;
                    ListaMatrices[x][y][z].Text = matrizLog[x][y][z].ToString();
                }
            }
             */
            for (int y=0; y <= f; y++)
            {
                for(int z = 0; z <= c; z++)
                {
                    Console.WriteLine(matrizLog[x][y][z]);
                    matrizLog[x][y][z] = matrizLog[x][y][z] * -1;
                    ListaMatrices[x][y][z].Text = matrizLog[x][y][z].ToString();
                }
            }
        }
        void guardarDatos(int m,int f, int c)
        {
            for(int x = 0; x <= f; x++)
            {
                for(int y = 0; y <= c; y++)
                {
                    if (ListaMatrices[m][x][y].Text.Length == 0)
                    {
                        lbl1.Visible = true;
                    }
                    else
                    {
                        matrizLog[m][x][y] = int.Parse(ListaMatrices[m][x][y].Text);
                    }                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guardarDatos(CmbMatriz.SelectedIndex, CmbFilas.SelectedIndex, CmbColumn.SelectedIndex);
            negativo(CmbMatriz.SelectedIndex,CmbFilas.SelectedIndex,CmbColumn.SelectedIndex);
        }

        private void a11_TextChanged(object sender, EventArgs e)
        {
            guardarDatos(CmbMatriz.SelectedIndex, CmbFilas.SelectedIndex, CmbColumn.SelectedIndex);
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


        private void button4_Click(object sender, EventArgs e)
        {
            guardarDatos(CmbMatriz.SelectedIndex, CmbFilas.SelectedIndex, CmbColumn.SelectedIndex);
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

        private void a12_TextChanged(object sender, EventArgs e)
        {
        }

        private void a13_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
