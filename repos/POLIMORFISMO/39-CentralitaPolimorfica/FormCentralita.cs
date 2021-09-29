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
    
    public partial class FormMenu : Form
    {
        public Centralita miCentralita;
        public FormMenu()
        {
            InitializeComponent();
            miCentralita = new Centralita("Tuenti");
    }

        private void btnGenerarLLamada_Click(object sender, EventArgs e)
        {
            FormLlamador formLlamador = new FormLlamador(miCentralita);
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FormFacturacion formFacturacion = new FormFacturacion(miCentralita, Entidades.LLamada.TipoLlamada.Todas);
            formFacturacion.Show();
        }
    }
}
