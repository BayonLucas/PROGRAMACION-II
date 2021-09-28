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
    public partial class FormFacturacion : Form
    {
        Entidades.LLamada.TipoLlamada criterioFacturacion;
        Centralita auxCentralita;
        public FormFacturacion(Centralita miCentralita, Entidades.LLamada.TipoLlamada criterioTipoLlamada)
        {
            InitializeComponent();
            this.CriterioFacturacion = criterioTipoLlamada;
            auxCentralita = miCentralita;
        }
        #region Propiedades
        public LLamada.TipoLlamada CriterioFacturacion 
        {
            set
            {
                if (value == Entidades.LLamada.TipoLlamada.Local)
                {
                    rtxtbFacturacion.Text = auxCentralita.GananciasPorTotal.ToString();
                    rtxtbFacturacion.AppendText("Local");
                }
                else if (value == Entidades.LLamada.TipoLlamada.Provincial)
                {
                    rtxtbFacturacion.Text = auxCentralita.GananciasPorProvincial.ToString();
                    rtxtbFacturacion.AppendText("provincial");
                }
                else
                {
                    rtxtbFacturacion.Text = auxCentralita.GananciasPorTotal.ToString();
                    rtxtbFacturacion.AppendText("Total");
                }
            }
        }
        #endregion

    }
}
