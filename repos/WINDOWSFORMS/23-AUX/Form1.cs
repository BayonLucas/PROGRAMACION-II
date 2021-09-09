using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetin;

namespace _23_AUX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDolar_click(object sender, EventArgs e)
        {
            double aux;
            if (!double.TryParse(txtDolarIngresado.Text, out aux))
            {
                MessageBox.Show("Ingrese solo numeros");
            }
            else
            {
                Dolar montoUsuarioDolar = aux;
                Euro montoConvertidoEuro = (Euro)montoUsuarioDolar;
                Pesos montoConvertidoPeso = (Pesos)montoUsuarioDolar;
                txtDisplayDolar2.Text = montoUsuarioDolar.GetCantidad().ToString();
                txtDisplayEuro2.Text = montoConvertidoEuro.GetCantidad().ToString();
                txtDisplayPeso2.Text = montoConvertidoPeso.GetCantidad().ToString();
            }

        }
        private void btnEuro_Click(object sender, EventArgs e) 
        {
            //al hacer click, hacer las conversiones de euro a pesos/dolar
            double aux;
            if(!double.TryParse(txtEuroIngresado.Text, out aux))
            {
                MessageBox.Show("Ingrese solo numeros");
            }
            else
            {
                Euro montoUsuarioEuro = aux;
                Dolar montoUsuarioDolar = (Dolar)montoUsuarioEuro;
                Pesos montoConvertidoPeso = (Pesos)montoUsuarioDolar;
                txtDisplayDolar1.Text = montoUsuarioDolar.GetCantidad().ToString();
                txtDisplayPeso1.Text = montoConvertidoPeso.GetCantidad().ToString();
                txtDisplayEuro1.Text = montoUsuarioEuro.GetCantidad().ToString();
            }
        }
        private void btnPesoConvertir_Click(object sender, EventArgs e)
        {
            double aux;
            if (!double.TryParse(txtPesoIngresado.Text, out aux))
            {
                MessageBox.Show("Ingrese solo numeros");
            }
            else
            {
                Pesos montoUsuarioPeso = aux;
                Euro montoUsuarioEuro = (Euro)montoUsuarioPeso;
                Dolar montoUsuarioDolar = (Dolar)montoUsuarioEuro;
                txtDisplayDolar3.Text = montoUsuarioDolar.GetCantidad().ToString();
                txtDisplayEuro3.Text = montoUsuarioEuro.GetCantidad().ToString();
                txtDisplayPeso3.Text = montoUsuarioPeso.GetCantidad().ToString();
            }
        }
    }
}
