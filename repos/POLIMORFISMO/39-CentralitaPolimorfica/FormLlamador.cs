using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace _40_CentralitaPolimorfica
{
    public partial class FormLlamador : Form
    {
        // Carga
        cmbFranja.DataSource = Enum.GetValues(typeof(Franjas));
        // Lectura
        Franjas franjas;
        Enum.TryParse<Franjas>(cmbFranja.SelectedValue.ToString(), out franjas);
        Centralita miCentralita;
        public FormLlamador(Centralita auxCentralita)
        {
            InitializeComponent();
            miCentralita = auxCentralita;
        }

        private void FormLlamador_Load(object sender, EventArgs e)
        {

        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random auxRandom = new Random();
            float auxDuracion = auxRandom.Next(1,50);
            //Si la llamada comienza con #, es Provincial.
            Provincial.Franja auxFranja = cmbFranja.SelectedText;
            LLamada auxLlamada;
            if (txtNroDestino.Text.First() == '#')       
            {
                auxLlamada = new Provincial(txtNroOrigen.Text, cmbFranja., auxDuracion, txtNroDestino.Text);
            }
        }
    }
}
