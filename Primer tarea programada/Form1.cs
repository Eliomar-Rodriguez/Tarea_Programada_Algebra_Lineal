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
        /// Variable que contiene el numero del paso (proceso) en el que se encuentra
        /// </summary>
        int numPaso = 0;
        /// <summary>
        /// lista que contiene las 3 matrices (a, b, c)
        /// </summary>
        List<List<List<TextBox>>> listaMatrices = new List<List<List<TextBox>>>();
        /// <summary>
        /// Matriz logica en donde se guardan los numeros que son ingresados a la matrz visual (cajas de texto)
        /// </summary>
        List<List<List<float>>> matrizLog = new List<List<List<float>>>();
        /// <summary>
        /// Contiene el tamaño actual de las matrices
        /// </summary>
        List<List<int>> dimensiones = new List<List<int>>();


        public Form1()
        {
            InitializeComponent();
            cmbMatriz.SelectedIndex = 0;
            cmbMatriz.Update();
            cmbFilas.SelectedIndex = 0;
            cmbInversa.SelectedIndex = 0;
            cmbFilas.Update();
            cmbColumn.SelectedIndex = 0;
            cmbColumn.Update();
            radioResta.Enabled = false;
            radioSuma.Enabled = false;
            radioMulti.Enabled = false;
            txtOperador.Enabled = false;
            radioInversa.Enabled = false;
            label9.Visible = false;
            radioMultiPorNum.Enabled = false;

            dimensiones.Add(new List<int>());
            dimensiones.Add(new List<int>());
            dimensiones.Add(new List<int>());
            dimensiones[0].Add(0);
            dimensiones[0].Add(0);
            dimensiones[1].Add(0);
            dimensiones[1].Add(0);
            dimensiones[2].Add(0);
            dimensiones[2].Add(0);

            // Creando toolTipText para mostrar al usuario descripciones de diferentes elementos de la vista 
            ToolTip toolTipText = new ToolTip();

            toolTipText.AutoPopDelay = 5000;
            toolTipText.InitialDelay = 1000;
            toolTipText.ReshowDelay = 500;

            toolTipText.ShowAlways = true;

            toolTipText.SetToolTip(this.cmbMatriz, "SELECCIONA la matriz a la que se desea APLICAR alguna OPERACIÓN.");
            toolTipText.SetToolTip(this.cmbFilas, "Selecciona la cantidad de FILAS que desea que tenga la matriz seleccionada.");
            toolTipText.SetToolTip(this.cmbColumn, "Selecciona la cantidad de COLUMNAS que desea que tenga la matriz seleccionada.");
            toolTipText.SetToolTip(this.cmbFilas, "CREA la matriz seleccionada con la cantidad de filas y columnas elegida.");

            toolTipText.SetToolTip(this.btnT, "Matriz transpuesta: TRASNPONE la matriz que se tenga seleccionada.");
            toolTipText.SetToolTip(this.radioMultiPorNum, "Multiplicación de un número real por la matriz que se tiene seleccionada.");
            toolTipText.SetToolTip(this.radioMulti, "Operación de MULTIPLICACIÓN entre la matriz A y la matriz B.");
            toolTipText.SetToolTip(this.radioResta, "Operación de RESTA entre la matriz A y la matriz B.");

            toolTipText.SetToolTip(this.radioSuma, "Operación de SUMA entre la matriz A y la matriz B.");
            toolTipText.SetToolTip(this.txtOperador, "Ingresa el número que desea Multiplicar por la matriz seleccionada.");
            toolTipText.SetToolTip(this.btnPasos, "Muestra PASO A PASO el proceso realizado para resolver la operación seleccionada.");
            toolTipText.SetToolTip(this.btnResolver, "Muestra el RESULTADO FINAL de la operación seleccionada.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 3; x++)
            {
                listaMatrices.Add(new List<List<TextBox>>());
                for (int y = 0; y < 5; y++)
                {
                    listaMatrices[x].Add(new List<TextBox>());
                }
            }
            
            for (int x = 0; x < 3; x++)
            {
                matrizLog.Add(new List<List<float>>());
                for (int y = 0; y < 5; y++)
                {
                    matrizLog[x].Add(new List<float>());
                    for (int z = 0; z < 5; z++)
                    {
                        matrizLog[x][y].Add(0);
                    }
                }
            }
            // matriz a

            listaMatrices[0][0].Add(a11);
            listaMatrices[0][0].Add(a12);
            listaMatrices[0][0].Add(a13);
            listaMatrices[0][0].Add(a14);
            listaMatrices[0][0].Add(a15);

            listaMatrices[0][1].Add(a21);
            listaMatrices[0][1].Add(a22);
            listaMatrices[0][1].Add(a23);
            listaMatrices[0][1].Add(a24);
            listaMatrices[0][1].Add(a25);

            listaMatrices[0][2].Add(a31);
            listaMatrices[0][2].Add(a32);
            listaMatrices[0][2].Add(a33);
            listaMatrices[0][2].Add(a34);
            listaMatrices[0][2].Add(a35);

            listaMatrices[0][3].Add(a41);
            listaMatrices[0][3].Add(a42);
            listaMatrices[0][3].Add(a43);
            listaMatrices[0][3].Add(a44);
            listaMatrices[0][3].Add(a45);

            listaMatrices[0][4].Add(a51);
            listaMatrices[0][4].Add(a52);
            listaMatrices[0][4].Add(a53);
            listaMatrices[0][4].Add(a54);
            listaMatrices[0][4].Add(a55);

            // matriz b

            listaMatrices[1][0].Add(b11);
            listaMatrices[1][0].Add(b12);
            listaMatrices[1][0].Add(b13);
            listaMatrices[1][0].Add(b14);
            listaMatrices[1][0].Add(b15);

            listaMatrices[1][1].Add(b21);
            listaMatrices[1][1].Add(b22);
            listaMatrices[1][1].Add(b23);
            listaMatrices[1][1].Add(b24);
            listaMatrices[1][1].Add(b25);

            listaMatrices[1][2].Add(b31);
            listaMatrices[1][2].Add(b32);
            listaMatrices[1][2].Add(b33);
            listaMatrices[1][2].Add(b34);
            listaMatrices[1][2].Add(b35);

            listaMatrices[1][3].Add(b41);
            listaMatrices[1][3].Add(b42);
            listaMatrices[1][3].Add(b43);
            listaMatrices[1][3].Add(b44);
            listaMatrices[1][3].Add(b45);

            listaMatrices[1][4].Add(b51);
            listaMatrices[1][4].Add(b52);
            listaMatrices[1][4].Add(b53);
            listaMatrices[1][4].Add(b54);
            listaMatrices[1][4].Add(b55);

            // matriz resultado

            listaMatrices[2][0].Add(c11);
            listaMatrices[2][0].Add(c12);
            listaMatrices[2][0].Add(c13);
            listaMatrices[2][0].Add(c14);
            listaMatrices[2][0].Add(c15);

            listaMatrices[2][1].Add(c21);
            listaMatrices[2][1].Add(c22);
            listaMatrices[2][1].Add(c23);
            listaMatrices[2][1].Add(c24);
            listaMatrices[2][1].Add(c25);

            listaMatrices[2][2].Add(c31);
            listaMatrices[2][2].Add(c32);
            listaMatrices[2][2].Add(c33);
            listaMatrices[2][2].Add(c34);
            listaMatrices[2][2].Add(c35);

            listaMatrices[2][3].Add(c41);
            listaMatrices[2][3].Add(c42);
            listaMatrices[2][3].Add(c43);
            listaMatrices[2][3].Add(c44);
            listaMatrices[2][3].Add(c45);

            listaMatrices[2][4].Add(c51);
            listaMatrices[2][4].Add(c52);
            listaMatrices[2][4].Add(c53);
            listaMatrices[2][4].Add(c54);
            listaMatrices[2][4].Add(c55);
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
                    listaMatrices[matriz][f][c].Visible = false;
                }
            }
        }
        /// <summary>
        /// Funcion que resuelve la operacion de suma entre matrices
        /// </summary>
        void Adicion(int operador)
        {
            if (!ValidarCampos(0) & !ValidarCampos(1)) // si esta vacia
            {
                lbl1.Text = "No pueden haber espacios vacios ni letras en ninguna de las dos matrices.";
                lbl1.Visible = true;
            }
            else
            {
                CambioDim(2, dimensiones[0][0], dimensiones[0][1]);
                for (int m = 0; m < 2; m++)
                {
                    for (int f = 0; f <= cmbFilas.SelectedIndex; f++)
                    {
                        for (int c = 0; c <= cmbColumn.SelectedIndex; c++)
                        {
                            listaMatrices[2][f][c].Text = (matrizLog[0][f][c] + operador * matrizLog[1][f][c]).ToString();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Funcion que resuelve la operacion de multiplicar matriz por matriz
        /// </summary>
        void Multiplicacion()
        {
            for (int m = 0; m <= dimensiones[0][0]; m++)
            {
                for (int n = 0; n <= dimensiones[1][1]; n++)
                {
                    int resultado = 0;
                    for (int k = 0; k <= dimensiones[0][1]; k++)
                    {
                        resultado += int.Parse(listaMatrices[0][m][k].Text) * int.Parse(listaMatrices[1][k][n].Text);
                    }
                    listaMatrices[2][m][n].Visible = true;
                    listaMatrices[2][m][n].Text = Convert.ToString(resultado);
                }
            }
        }

        /// <summary>
        /// Boton que resuelve la operacion seleccionada
        /// </summary>
        private void btnResolver_Click(object sender, EventArgs e)
        {
            txtOperador.Enabled = false;
            OcultarCajas(2);
            BorrarInv(2);
            if (radioMultiPorNum.Checked & ValidarCampos(cmbMatriz.SelectedIndex))
            {
                int z = 0;
                if (int.TryParse(txtOperador.Text, out z))
                    MultiMatrizPorReal(cmbMatriz.SelectedIndex, dimensiones[cmbMatriz.SelectedIndex][0], dimensiones[cmbMatriz.SelectedIndex][1], z, 2);
            }
            else if (ValidarCampos(0) & ValidarCampos(1)) // si ambas funciones solo tienen numeros y no tiene espacios guarda datos
            {
                GuardarDatos(0, dimensiones[0][0], dimensiones[0][1]);
                GuardarDatos(1, dimensiones[1][0], dimensiones[1][1]);
                if (radioSuma.Checked)
                {
                    
                    Adicion(1);
                }
                else if (radioResta.Checked)
                {
                    Adicion(-1);
                }
            }
            else if (radioMulti.Checked & ValidarCampos(0) & ValidarCampos(2))
            {
                GuardarDatos(0, dimensiones[0][0], dimensiones[0][1]);
                GuardarDatos(1, dimensiones[1][0], dimensiones[1][1]);
                if (dimensiones[0][1] == dimensiones[1][0])
                {
                    Multiplicacion();
                }
                else
                {
                    lbl1.Text = "Las matrices no son compatibles";
                    lbl1.Visible = true;
                }
            }
            else
            {
                lbl1.Text = "No pueden haber espacios vacios ni letras en ninguna de las dos matrices.";
                lbl1.Visible = true;
            }
        }
        /// <summary>
        /// Actualiza la matriz visual a partir de la matriz lógica
        /// </summary>
        /// <param name="matriz">Matriz a actualizar</param>
        private void ActMatVisual(int matriz)
        {
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                    if (listaMatrices[matriz][x][y].Visible)
                        listaMatrices[matriz][x][y].Text = matrizLog[matriz][x][y].ToString();
            }
        }
        /// <summary>
        /// Borra los datos en la matriz logica y en la matriz de cajas, las cajas que en la matriz visual estan invisible
        /// </summary>
        /// <param name="matriz">Posicion de la matriz en la que desea borrar</param>
        private void BorrarInv(int matriz)
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    if (!listaMatrices[matriz][a][b].Visible)
                    {
                        matrizLog[matriz][a][b] = 0;
                        listaMatrices[matriz][a][b].Text = "";
                    }
                }
            }
        }
        /// <summary>
        /// Modifica el tamaño de la matriz lógica indicada
        /// </summary>
        /// <param name="x">Matriz a redimencionar</param>
        /// <param name="y">Cantidad de filas que tiene que tener luego del cambio</param>
        /// <param name="z">Cantidad de columnas que tiene que tener luego del cambio</param>
        private void CambioDim(int x, int y, int z)
        {
            
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    if (a <= y && b <= z)
                    {
                        listaMatrices[x][a][b].Visible = true;
                    }
                    else
                    {
                        listaMatrices[x][a][b].Visible = false;
                    }
                }
            }
            dimensiones[x][0] = y;
            dimensiones[x][1] = z;
            // Inversa
            if (dimensiones[cmbMatriz.SelectedIndex][0] <= 2 & dimensiones[cmbMatriz.SelectedIndex][1] <= 2 & dimensiones[cmbMatriz.SelectedIndex][0]== dimensiones[cmbMatriz.SelectedIndex][1]) // si la matriz seleccionada tiene f y c >= a 2 entonces puede operar con inversa
            {
                radioInversa.Enabled = true;
                OcultarCajas(2);
                MostrarMatrizFinal(dimensiones[cmbMatriz.SelectedIndex][0], dimensiones[cmbMatriz.SelectedIndex][1]);
            }
            else
            {
                radioInversa.Enabled = false;
                radioInversa.Checked = false;
            }
            // Suma y resta
            if (dimensiones[0][0] == dimensiones[1][0] && dimensiones[0][1] == dimensiones[1][1]) // si las filas y columnas de la matriz A y B son iguales puede sumar y restar
            {
                radioResta.Enabled = true;
                radioSuma.Enabled = true;
                OcultarCajas(2);
                MostrarMatrizFinal(dimensiones[0][0],dimensiones[0][1]);
                /*for (int f = 0; f <= cmbFilas.SelectedIndex; f++)
                {
                    for (int c = 0; c < cmbColumn.SelectedIndex; c++)
                    {
                        listaMatrices[2][f][c].Visible = true;
                    }
                }*/
            }
            else
            {
                radioResta.Checked = false;
                radioSuma.Checked = false;
                radioResta.Enabled = false;
                radioSuma.Enabled = false;
            }
            // multiplicacion entre matriz A y matriz B
            if (dimensiones[0][1] == dimensiones[1][0]) // multiplicacion entre matrices, esto valida igualdad entre columnas de A con filas de B
            {
                radioMulti.Enabled = true;
                OcultarCajas(2);
                MostrarMatrizFinal(dimensiones[0][0],dimensiones[1][1]);
            }
            else
            {
                radioMulti.Checked = false;
                radioMulti.Enabled = false;
            }
        }
        /// <summary>
        /// Funcion encargada de transponer una matriz
        /// </summary>
        /// <param name="matriz">Matriz a trasnponer</param>
        private void Transpuesta(int matriz)
        {
            float aux = 0;
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < x; y++)
                {
                    aux = matrizLog[matriz][x][y];
                    matrizLog[matriz][x][y] = matrizLog[matriz][y][x];
                    matrizLog[matriz][y][x] = aux;
                }
            }
            CambioDim(matriz, dimensiones[matriz][1], dimensiones[matriz][0]);
            ActMatVisual(matriz);
        }

        /// <summary>
        /// Funcion que multiplica una matriz por un numero real
        /// </summary>
        /// <param name="MatOrigen">Matriz de origen</param>
        /// <param name="f">Cantidad de Filas</param>
        /// <param name="c">Cantidad de Columnas</param>
        /// <param name="operador">Numero recibido el cual va a multiplicar la matriz</param>
        /// <param name="matDestino">Posicion de la matriz en la lista de matrices</param>
        private void MultiMatrizPorReal(int MatOrigen, int f, int c, int operador, int matDestino)
        {
            GuardarDatos(MatOrigen, dimensiones[MatOrigen][0], dimensiones[MatOrigen][1]);
            CambioDim(matDestino, dimensiones[MatOrigen][0], dimensiones[MatOrigen][1]);
            for (int y = 0; y <= f; y++)
            {
                for (int z = 0; z <= c; z++)
                {
                    Console.WriteLine(matrizLog[MatOrigen][y][z]);
                    matrizLog[matDestino][y][z] = matrizLog[MatOrigen][y][z] * operador;
                    listaMatrices[matDestino][y][z].Text = matrizLog[matDestino][y][z].ToString();
                }
            }
        }

        /// <summary>
        /// Funcion que guarda los datos ingresados en la matriz visual y los almacena en la matriz logica
        /// </summary>
        /// <param name="m">Posicion de la matriz en la que se desea almacenar</param>
        /// <param name="f">Cantidad de filas de las matrices actuales</param>
        /// <param name="c">Cantidad de columnas de las matrices actuales</param>
        void GuardarDatos(int m,int f, int c)
        {
            for (int x = 0; x <= f; x++)
            {
                for (int y = 0; y <= c; y++)
                {
                    if (listaMatrices[m][x][y].Text.Length == 0)
                    {
                        lbl1.Visible = true;
                    }
                    else
                    {
                        matrizLog[m][x][y] = int.Parse(listaMatrices[m][x][y].Text);
                    }
                }
            }
        }
        /// <summary>
        /// Funcion para validar los datos ingresados en las cajas de texto de la matriz visual
        /// Retorna true si esta llena de numeros y false si tiene letras
        /// </summary>
        /// <param name="m">Matriz seleccionada por el jugador</param>
        bool ValidarCampos(int m)
        {
            int num = 0;
            for (int f = 0; f <= dimensiones[m][0]; f++) // recorriendo filas
            {
                for (int c = 0; c <= dimensiones[m][1]; c++) // recorriendo columnas
                {
                    if (listaMatrices[m][f][c].Visible == true & (listaMatrices[m][f][c].Text.Length == 0 | !int.TryParse(listaMatrices[m][f][c].Text, out num))) // si esta caja de texto esta vacia alerta
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        /// <summary>
        /// Función que muestra la cantidad correcta de filas y columnas dependiendo de la operación seleccionada
        /// </summary>
        /// <param name="f">Cantidad de filas</param>
        /// <param name="c">Cantidad de columnas</param>
        void MostrarMatrizFinal(int f,int c)
        {
            for(int i = 0; i <= f; i++)
            {
                for(int j = 0; j <= c; j++)
                {
                    listaMatrices[2][i][j].Visible = true;
                }
            }
        }
        
        private void radioSuma_CheckedChanged(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            numPaso = 0;
            lblMsg.Text = "+";
            btnPasos.Text = "Paso 1";
            btnResolver.Visible = true;
            btnResolver.Visible = true;
            btnPasos.Visible = true;
            MostrarMatrizFinal(dimensiones[0][0], dimensiones[1][1]);
        }

        private void radioResta_CheckedChanged(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            lblMsg.Text = "-";
            numPaso = 0;
            btnPasos.Text = "Paso 1";
            btnResolver.Visible = true;
            MostrarMatrizFinal(dimensiones[0][0], dimensiones[1][1]);
        }

        private void radioMulti_CheckedChanged(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            lblMsg.Text = "*";
            numPaso = 0;
            btnPasos.Text = "Paso 1";
            btnResolver.Visible = true;
            MostrarMatrizFinal(dimensiones[0][0], dimensiones[1][1]);            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            radioMultiPorNum.Enabled = true;
            btnResolver.Visible = true;
            btnPasos.Visible = true;
            CambioDim(cmbMatriz.SelectedIndex, cmbFilas.SelectedIndex, cmbColumn.SelectedIndex);
            BorrarInv(cmbMatriz.SelectedIndex);
        }

        private void btnPasos_Click(object sender, EventArgs e)
        {
            // variable utilizada para validar que las cajas de texto solo contengan numeros
            int num = 0;
            if (ValidarCampos(0)==false & ValidarCampos(1)==false)
            {
                lbl1.Text = "No pueden haber espacios vacios ni letras en ninguna de las dos matrices.";
                lbl1.Visible = true;
            }
            else
            {
                // ingreso de numeros desde matriz de cajas de texto a matriz logica
                GuardarDatos(0, dimensiones[0][0], dimensiones[0][1]);
                GuardarDatos(1, dimensiones[1][0], dimensiones[1][1]);

                if (radioSuma.Checked) // en caso que desee sumar y tenga el radiobutton de sumar seleccionado
                {
                    if (numPaso == 0)
                    {
                        CambioDim(2, dimensiones[0][0], dimensiones[0][1]);
                        for (int m = 0; m < 2; m++)
                        {
                            for (int f = 0; f <= cmbFilas.SelectedIndex; f++)
                            {
                                for (int c = 0; c <= cmbColumn.SelectedIndex; c++)
                                {
                                    listaMatrices[2][f][c].Text = matrizLog[0][f][c].ToString() + " + " + matrizLog[1][f][c].ToString();
                                }
                            }
                        }
                        numPaso++;
                        btnPasos.Text = "Paso 2";
                    }
                    else if (numPaso == 1)
                    {
                        CambioDim(2, dimensiones[0][0], dimensiones[0][1]);
                        for (int m = 0; m < 2; m++)
                        {
                            for (int f = 0; f <= cmbFilas.SelectedIndex; f++)
                            {
                                for (int c = 0; c <= cmbColumn.SelectedIndex; c++)
                                {
                                    listaMatrices[2][f][c].Text = (matrizLog[0][f][c] + matrizLog[1][f][c]).ToString();
                                }
                            }
                        }
                        btnPasos.Text = "Paso 1";
                        numPaso = 0;
                    }
                }
                else if (radioResta.Checked) // en caso que desee restar y tenga el radiobutton de sumar seleccionado
                {
                    if (numPaso == 0)
                    {
                        CambioDim(2, dimensiones[0][0], dimensiones[0][1]);
                        for (int m = 0; m < 2; m++)
                        {
                            for (int f = 0; f <= cmbFilas.SelectedIndex; f++)
                            {
                                for (int c = 0; c <= cmbColumn.SelectedIndex; c++)
                                {
                                    listaMatrices[2][f][c].Text = matrizLog[0][f][c].ToString() + " - " + matrizLog[1][f][c].ToString();
                                }
                            }
                        }
                        numPaso++;
                        btnPasos.Text = "Paso 2";
                    }
                    else if (numPaso == 1)
                    {
                        CambioDim(2, dimensiones[0][0], dimensiones[0][1]);
                        for (int m = 0; m < 2; m++)
                        {
                            for (int f = 0; f <= cmbFilas.SelectedIndex; f++)
                            {
                                for (int c = 0; c <= cmbColumn.SelectedIndex; c++)
                                {
                                    listaMatrices[2][f][c].Text = (matrizLog[0][f][c] - matrizLog[1][f][c]).ToString();
                                }
                            }
                        }
                        btnPasos.Text = "Paso 1";
                        numPaso = 0;
                    }
                }
                else if (radioMultiPorNum.Checked) // en caso que desee multiplicar por un numero y tenga el radiobutton de sumar seleccionado
                {
                    if (!int.TryParse(txtOperador.Text, out num)) //si tiene letras
                    {
                        label9.Text = "Multiplica por la matriz seleccionada por donde dice tamaño";
                        label9.Visible = true;
                    }
                    else
                    {
                        if (numPaso == 0)
                        {
                            CambioDim(2, dimensiones[0][0], dimensiones[0][1]);
                            for (int f = 0; f <= cmbFilas.SelectedIndex; f++)
                            {
                                for (int c = 0; c <= cmbColumn.SelectedIndex; c++)
                                {
                                    listaMatrices[2][f][c].Text = txtOperador.Text + " * " + matrizLog[cmbMatriz.SelectedIndex][f][c].ToString();
                                }
                            }
                            numPaso++;
                            btnPasos.Text = "Paso 2";
                        }
                        else if (numPaso == 1)
                        {
                            CambioDim(2, dimensiones[0][0], dimensiones[0][1]);
                            for (int f = 0; f <= cmbFilas.SelectedIndex; f++)
                            {
                                for (int c = 0; c <= cmbColumn.SelectedIndex; c++)
                                {
                                    listaMatrices[2][f][c].Text = (int.Parse(txtOperador.Text) * matrizLog[cmbMatriz.SelectedIndex][f][c]).ToString();
                                }
                            }
                            numPaso = 0;
                            btnPasos.Text = "Paso 1";
                        }
                    }
                }
                else if (radioMultiPorNum.Checked)
                {
                    if (numPaso == 0)
                    {
                        //CambioDim(2, dimensiones[0][0], dimensiones[0][1]);
                        for (int m = 0; m < 2; m++)
                        {
                            for (int f = 0; f <= cmbFilas.SelectedIndex; f++)
                            {
                                for (int c = 0; c <= cmbColumn.SelectedIndex; c++)
                                {
                                    listaMatrices[2][f][c].Text = (txtOperador.Text + " * " + matrizLog[cmbMatriz.SelectedIndex][f][c]).ToString();
                                }
                            }
                        }
                        numPaso++;
                        btnPasos.Text = "Paso 2";
                    }
                    else if (numPaso == 1)
                    {
                        //CambioDim(2, dimensiones[0][0], dimensiones[0][1]);
                        for (int m = 0; m < 2; m++)
                        {
                            for (int f = 0; f <= cmbFilas.SelectedIndex; f++)
                            {
                                for (int c = 0; c <= cmbColumn.SelectedIndex; c++)
                                {
                                    listaMatrices[2][f][c].Text = (matrizLog[0][f][c] - matrizLog[1][f][c]).ToString();
                                }
                            }
                        }
                        btnPasos.Text = "Paso 1";
                        numPaso = 0;
                    }
                }
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            Transpuesta(cmbMatriz.SelectedIndex);
        }
        public List<List<float>> clonarM(List<List<float>> original)
        {
            List<List<float>> clon = new List<List<float>>();
            for (int i = 0; i < original.Count; i++)
            {
                clon.Add(new List<float>());
                for (int x = 0; x < original[i].Count; x++)
                {
                    clon[i].Add(original[i][x]);
                }
            }
            return clon;
        }
        /// <summary>
        /// Funcion encargada de llenar la matriz de cofactores a partir de la matriz enviada
        /// </summary>
        /// <param name="matriz">Matriz en la cual se va a trabajar para sacar los cofactores</param>
        /// <returns>Retorna una matriz llena con los cofactores para proceder a multiplicarla por el determinante</returns>
        public List<List<float>> matrizCofactores(List<List<float>> matriz)
        {
            List<List<float>> mCofactores = clonarM(matriz) ;

            for (int x = 0; x < mCofactores.Count; x++)
            {
                for (int y = 0; y < mCofactores.Count; y++)
                {
                    mCofactores[x][y] = cofactor(x, y, clonarM(matriz));
                }
            }
            return mCofactores;
        }
        /// <summary>
        /// Funcion encargada de sacar el cofactor
        /// </summary>
        /// <param name="i">Fila seleccionada</param>
        /// <param name="j">Columna seleccionada</param>
        /// <param name="matriz">Matriz de la cual se va a sacar el cofactor</param>
        /// <returns>Retorna el numero cofactor</returns>
        public float cofactor(int i, int j, List<List<float>> matriz)
        {
            if ((i + j) % 2 == 0)
                return Menor(i,j, clonarM(matriz));
            else
                return (-1) * Menor(i, j, clonarM(matriz));
        }
        /// <summary>
        /// Saca el menor M en las posiciones ij
        /// </summary>
        /// <param name="i">Fila seleccionada</param>
        /// <param name="j">Columna seleccionada</param>
        /// <param name="matriz">Matriz en la cual va a buscar el menor</param>
        /// <returns>Retorna el resultado del menor</returns>
        public float Menor(int i,int j, List<List<float>> matriz)
        {
            matriz.RemoveAt(i);
            for (int x = 0; x < matriz.Count; x++)
            {
                matriz[x].RemoveAt(j);
            }
            return Determinante(clonarM(matriz));
        }
        /// <summary>
        /// Funcion encargada de sacar el determinante
        /// </summary>
        /// <param name="matriz">Matriz a la cual le va a sacar determinante</param>
        /// <returns>Retorna el determinante de la matriz</returns>
        public float Determinante(List<List<float>> matriz)
        {
            if (matriz.Count == 1)
            {
                return matriz[0][0];
            }
            else if (matriz.Count == 2)
            {
                return (matriz[0][0] * matriz[1][1]) - (matriz[0][1] * matriz[1][0]);
            }
            else
            {
                float dety=0;
                for (int i = 0; i < matriz.Count; i++)
                {
                    dety+=matriz[1][i] * cofactor(1, i, clonarM(matriz));
                }
                return dety;
            }
        }
        private void btnInversa_Click(object sender, EventArgs e)
        {
            if (cmbInversa.SelectedIndex == 1)
            {
                if (dimensiones[cmbMatriz.SelectedIndex][0]== dimensiones[cmbMatriz.SelectedIndex][1]) // si tiene la cantidad de filas igual a la cantidad de columnas quiere decir que es cuadrada xD
                {
                    SacarCofactor();
                }
            }
        }

        private void radioInversa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInversa.Checked)
            {
                pnlInversa.Visible = true;
            }
            else
            {
                pnlInversa.Visible = false;
            }
        }

        private void radioMultiPorNum_CheckedChanged(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            numPaso = 0;
            btnPasos.Text = "Paso 1";
            btnResolver.Visible = true;
            txtOperador.Text = "";
            MostrarMatrizFinal(cmbFilas.SelectedIndex, cmbColumn.SelectedIndex);
            if (radioMultiPorNum.Checked)
            {
                txtOperador.Enabled = true;
                label9.Visible = true;
            }
            else
            {
                txtOperador.Enabled = false;
            }
        }
       /// <summary>
       /// Funcion encargada de sacar la matriz inversa utilizando el metodo de cofactor
       /// </summary>
        public void SacarCofactor()
        {
            GuardarDatos(0, dimensiones[cmbMatriz.SelectedIndex][0], dimensiones[cmbMatriz.SelectedIndex][1]);
            List<List<float>> muestra = new List<List<float>>();
            for (int i = 0; i <= dimensiones[cmbMatriz.SelectedIndex][0]; i++)
            {
                muestra.Add(new List<float>());
                for (int j = 0; j <= dimensiones[cmbMatriz.SelectedIndex][1]; j++)
                {
                    muestra[i].Add(matrizLog[0][i][j]);
                }
            }
            
            List<List<float>> print = matrizCofactores(muestra.ToList());
            for (int x = 0; x <= dimensiones[0][0]; x++)
            {
                for (int y = 0; y <= dimensiones[0][1]; y++)
                {
                    Console.Write(print[x][y] + " ");
                }
                Console.WriteLine();
            }

            float det = cofactor(0, 0, print.ToList()); // determinante
            MostrarMatrizFinal(dimensiones[cmbMatriz.SelectedIndex][0], dimensiones[cmbMatriz.SelectedIndex][1]);
            for (int f = 0; f < print.Count; f++)
            {
                for (int c = 0; c < print.Count; c++)
                {
                    //Console.WriteLine(dimensiones[2][1]);
                    matrizLog[2][f][c] = (1/det) * print[c][f];
                    Console.Write(matrizLog[2][f][c] + " ");
                    listaMatrices[2][f][c].Text = matrizLog[2][f][c].ToString();
                }
                Console.WriteLine();
            }
            
        }
    }
}
