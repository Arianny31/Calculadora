using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {

        //Variables
        string operador = "";
        double valor1 = 0;
        double valor2 = 0;
        double resultado=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
           
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";

            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";

            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";

            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";

            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";

            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {

            if (txtPantalla.Text == "0") txtPantalla.Text = "";

            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";

            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            valor1 = 0;
            valor2= 0;
            resultado = 0;
            operador = "";
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length == 1) txtPantalla.Text = "0";
            else txtPantalla.Text=txtPantalla.Text.Substring(0, txtPantalla.Text.Length -1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ".";
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            valor1=Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "0";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            valor1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "0";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "x";
            valor1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "0";
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            operador = "/";
            valor1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "0";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            
            valor2= Convert.ToDouble(txtPantalla.Text);
            switch (operador)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "x":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    break;
                default:
                {
                        txtPantalla.Text = "ERROR";
                        break;
                }
            }
            txtPantalla.Text = resultado.ToString();
        }
    }
}
