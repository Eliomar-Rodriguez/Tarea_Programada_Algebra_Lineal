﻿using System;
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
        
        static int filas = 0, columnas = 0;

        static int[,] matrizA = new int[filas, columnas];

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
        void OcultarCajas()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int f = 0; f < 5; f++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        ListaMatrices[i][f][c].Visible = false;                        
                    }
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

        /// <summary>
        /// Boton que genera (crea) la matriz
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            OcultarCajas();

            if (txtFilas.Text.Length == 0 | txtColumnas.Text.Length == 0)
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Debe ingresar ambos valores para generar la matriz.";
            }
            else
            {
                bool rows = int.TryParse(txtFilas.Text, out filas);
                bool columns = int.TryParse(txtColumnas.Text, out columnas);

                if (!rows | !columns) // si es true (eran solo numeros)
                {
                    lblMsg.ForeColor = Color.Red;
                    lblMsg.Text = "Debe ingresar solamente numeros.";
                }
                else
                {
                    if ((filas <= 5 & columnas <= 5) & (filas > 0 & columnas > 0))
                    {
                        lblMsg.Text = "Matriz creada de manera exitosa.";
                        lblMsg.ForeColor = Color.Green;

                        filas = int.Parse(txtFilas.Text);
                        columnas = int.Parse(txtColumnas.Text);

                        for (int i = 0; i < 2; i++)
                        {
                            for (int f = 0; f < int.Parse(txtFilas.Text); f++)
                            {
                                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                                {
                                    ListaMatrices[i][f][c].Visible = true;
                                }
                            }
                        }                        
                    }
                    else
                    {
                        lblMsg.ForeColor = Color.Red;
                        lblMsg.Text = "Debe solo ingresar #`s >= 1 y #`s <= 5.";
                    }
                }
            }
        }
    }
}
