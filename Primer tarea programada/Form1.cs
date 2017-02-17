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

            // matriz resultado

            ListaMatrices[2][0].Add(c11);
            ListaMatrices[2][0].Add(c12);
            ListaMatrices[2][0].Add(c13);
            ListaMatrices[2][0].Add(c14);
            ListaMatrices[2][0].Add(c15);

            ListaMatrices[2][1].Add(c21);
            ListaMatrices[2][1].Add(c22);
            ListaMatrices[2][1].Add(c23);
            ListaMatrices[2][1].Add(c24);
            ListaMatrices[2][1].Add(c25);

            ListaMatrices[2][2].Add(c31);
            ListaMatrices[2][2].Add(c32);
            ListaMatrices[2][2].Add(c33);
            ListaMatrices[2][2].Add(c34);
            ListaMatrices[2][2].Add(c35);

            ListaMatrices[2][3].Add(c41);
            ListaMatrices[2][3].Add(c42);
            ListaMatrices[2][3].Add(c43);
            ListaMatrices[2][3].Add(c44);
            ListaMatrices[2][3].Add(c45);
        
            ListaMatrices[2][4].Add(c51);
            ListaMatrices[2][4].Add(c52);
            ListaMatrices[2][4].Add(c53);
            ListaMatrices[2][4].Add(c54);
            ListaMatrices[2][4].Add(c55);
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
        /// <summary>
        /// Funcion que resuelve la operacion de sumar
        /// </summary>
        void sumar()
        {
            if (!validarCampos(0) & !validarCampos(1)) // si esta vacia
            {
                lbl1.Text = "No pueden haber espacios vacios ni letras en ninguna de las dos matrices.";
                lbl1.Visible = true;
            }
            else
            {
                for(int m = 0; m < 2; m++)
                {
                    for (int f = 0; f <= CmbFilas.SelectedIndex; f++)
                    {
                        for (int c = 0; c <= CmbColumn.SelectedIndex; c++)
                        {
                            ListaMatrices[2][f][c].Text = (matrizLog[0][f][c] + matrizLog[1][f][c]).ToString();
                        }
                    }
                }                
            }
        }
        /// <summary>
        /// Boton que resuelve la operacion seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (validarCampos(0) & validarCampos(1)) // si ambas funciones solo tienen numeros y no tiene espacios guarda datos
            {
                guardarDatos(0, dimensiones[0][0], dimensiones[0][1]);
                guardarDatos(1, dimensiones[1][0], dimensiones[1][1]);
                sumar();
            }
            else
            {                
                lbl1.Text = "No pueden haber espacios vacios ni letras en ninguna de las dos matrices.";
                lbl1.Visible = true;
            }           
        }

        private void actVistaM(int matriz)
        {
            for(int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                    if(ListaMatrices[matriz][x][y].Visible)
                        ListaMatrices[matriz][x][y].Text = matrizLog[matriz][x][y].ToString();
            }
        }

        private void borrarInv(int matriz)
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    if (!ListaMatrices[matriz][a][b].Visible)
                    {
                        matrizLog[matriz][a][b] = 0;
                        ListaMatrices[matriz][a][b].Text = "";
                    }
                }
            }
        }

        private void cambiodim(int x, int y, int z)
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
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
                for(int f = 0; f <= CmbFilas.SelectedIndex; f++)
                {
                    for(int c = 0; c < CmbColumn.SelectedIndex; c++)
                    {
                        ListaMatrices[2][f][c].Visible = true;                    
                    }
                }
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

        private void transpuesta(int matriz)
        {
            int aux = 0;
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < x; y++)
                {
                    aux = matrizLog[matriz][x][y];
                    matrizLog[matriz][x][y] = matrizLog[matriz][y][x];
                    matrizLog[matriz][y][x] = aux;
                }
            }
            cambiodim(matriz, dimensiones[matriz][1], dimensiones[matriz][0]);
            actVistaM(matriz);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarCampos(CmbMatriz.SelectedIndex)) // si la funcion retorna true entonces solamente tiene numeros y no tiene espacios
            {
                guardarDatos(CmbMatriz.SelectedIndex, dimensiones[CmbMatriz.SelectedIndex][0], dimensiones[CmbMatriz.SelectedIndex][1]);
                transpuesta(CmbMatriz.SelectedIndex);
                borrarInv(CmbMatriz.SelectedIndex);
            }
            else
            {
                if (CmbMatriz.SelectedIndex == 0)
                {
                    lbl1.Text = "No pueden haber espacios vacios ni letras en la matriz A";
                }
                else
                {
                    lbl1.Visible = true;
                }
            }
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

        /// <summary>
        /// Boton que genera (crea) la matriz
        /// </summary>
        /// 
        private void button1_Click_1(object sender, EventArgs e)
        {
            //guardarDatos(CmbMatriz.SelectedIndex, dimensiones[CmbMatriz.SelectedIndex][0], dimensiones[CmbMatriz.SelectedIndex][1]);
            cambiodim(CmbMatriz.SelectedIndex, CmbFilas.SelectedIndex, CmbColumn.SelectedIndex);
            borrarInv(CmbMatriz.SelectedIndex);
            btnResolver.Visible = true;
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
        /// <summary>
        /// Funcion para validar los datos ingresados en las cajas de texto de la matriz visual
        /// Retorna true si esta llena de numeros y false si tiene letras
        /// </summary>
        /// <param name="m">Matriz seleccionada por el jugador</param>
        bool validarCampos(int m)
        {
            int num = 0;
            for (int f = 0; f <= CmbFilas.SelectedIndex; f++) // recorriendo filas
            {
                for(int c = 0; c <= CmbColumn.SelectedIndex; c++) // recorriendo columnas
                {
                    if (ListaMatrices[m][f][c].Text.Length == 0 | int.TryParse(ListaMatrices[m][f][c].Text,out num) == false) // si esta caja de texto esta vacia alerta
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (validarCampos(CmbMatriz.SelectedIndex)) // si la funcion retorna true entonces solamente tiene numeros y no tiene espacios
            {
                guardarDatos(CmbMatriz.SelectedIndex, dimensiones[CmbMatriz.SelectedIndex][0], dimensiones[CmbMatriz.SelectedIndex][1]);
                actVistaM(CmbMatriz.SelectedIndex);
                negativo(CmbMatriz.SelectedIndex, dimensiones[CmbMatriz.SelectedIndex][0], dimensiones[CmbMatriz.SelectedIndex][1]);
            }
            else
            {
                if (CmbMatriz.SelectedIndex == 0)
                {
                    lbl1.Text = "No pueden haber espacios vacios ni letras en la matriz A";
                }
                else
                {
                    lbl1.Text = "No pueden haber espacios vacios ni letras en la matriz B";
                }                
                lbl1.Visible = true;
            }
        }

        private void a11_TextChanged(object sender, EventArgs e)
        {
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
        /// <summary>
        /// Funcion para validar los datos ingresados en los campos de la matriz visual ya que solo pueden ser numeros enteros
        /// </summary>
        void validarEspacios()
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

        private void radioSuma_CheckedChanged(object sender, EventArgs e)
        {
            btnResolver.Visible = true;
        }

        private void radioResta_CheckedChanged(object sender, EventArgs e)
        {
            btnResolver.Visible = true;
        }

        private void radioMulti_CheckedChanged(object sender, EventArgs e)
        {
            btnResolver.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnResolver.Visible = true;
        }
    }
}
