using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{

    public class Provincial : LLamada
    {
        //Franja_1: 0.99, Franja_2: 1.25 y Franja_3: 0.66.
        public enum Franja { Franja_1 = (float)0.99, Franja_2 = (float)1.25, Franka_3 = (float)0.66 };
        //public enum Franja {Franja_1 = 1, Franja_2= 2, Franka_3=3 };
        protected Franja franjaHoraria;
        #region Constructores
        public Provincial(string origen, Franja miFranja,float duracion,string destino) : base(duracion, destino, origen)
        {
                this.franjaHoraria = miFranja;
        }
        public Provincial(LLamada llamada, Franja miFranja) : this(llamada.NroOrigen,miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }
        #endregion
        #region Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion
        #region Metodos
        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                    case Franja.Franja_1:
                        return this.Duracion * (float)0.99;
                    case Franja.Franja_2:
                        return this.Duracion * (float)1.25;
                    case Franja.Franka_3:
                        return this.Duracion * (float)0.66;
            }
                return 0;
        }
        public new string Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            return ((aux.Append(base.Mostrar()).Append(this.franjaHoraria)).Append(this.CostoLlamada.ToString())).ToString();
        }
        #endregion


    }
}
