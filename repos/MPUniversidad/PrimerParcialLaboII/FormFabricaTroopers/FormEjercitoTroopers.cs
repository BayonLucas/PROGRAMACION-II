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
namespace FormFabricaTroopers
{
    public partial class FormEjercitoTroopers : Form
    {
        private EjercitoImperial ejercitoImperial;
        public FormEjercitoTroopers()
        {
            ejercitoImperial = new EjercitoImperial(10);
            Troopper auxTrooperArena = new TrooperArena(Blaster.EC17);
            ejercitoImperial += auxTrooperArena;
            InitializeComponent();
        }
        private void RefrescarEjercito()
        {
            lstEjercito.Items.Clear();
            foreach (Troopper item in ejercitoImperial.Troopers)
            {
                lstEjercito.Items.Add(item.InfoTrooper());
            }            
        }
        private void FormEjercitoTroopers_Load(object sender, EventArgs e)
        {
            RefrescarEjercito();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbTipo.SelectedItem.ToString()))
            {
                string auxTipo = cmbTipo.SelectedItem.ToString();
                switch (auxTipo)
                {
                    case "Tropper Arena":                        
                        Troopper auxTrooperArena = new TrooperArena(Blaster.EC17);
                        this.ejercitoImperial += auxTrooperArena;
                        break;
                    case "Tropper Asalto":
                        
                        Troopper auxTrooperAsalto = new TrooperAsalto(Blaster.E11);
                        this.ejercitoImperial += auxTrooperAsalto;
                        break;
                    case "Tropper Explorador":
                        
                        Troopper auxTrooperExplorador = new TrooperExplorador("Moto");
                        this.ejercitoImperial += auxTrooperExplorador;
                        break;
                }
                RefrescarEjercito();
            }    
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string auxTipo = cmbTipo.SelectedText;
            Troopper auxNuevoTrooper = null;
            switch (auxTipo)
            {
                case "Tropper Arena":
                    auxNuevoTrooper = new TrooperArena(Blaster.EC17);                    
                    break;
                case "Tropper Asalto":
                    auxNuevoTrooper = new TrooperAsalto(Blaster.E11);
                    break;
                case "Tropper Explorador":
                    auxNuevoTrooper = new TrooperExplorador("Moto");
                    break;
            }
            this.ejercitoImperial = this.ejercitoImperial - auxNuevoTrooper;
            RefrescarEjercito();
        }
    }
}
