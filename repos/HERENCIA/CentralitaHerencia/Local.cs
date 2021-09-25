using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : LLamada
    {
        protected float costo;
        #region Constructores
        //public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        //{
        //    this.costo = costo;
        //}
        //public Local(LLamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        //{


        //}
        #endregion
        #region alternativa de constructor
        public Local(string origen, float duracion, string destino, float costo) : this(new LLamada(duracion, destino, origen), costo)
        {
            this.costo = costo;
        }
        public Local(LLamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
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
            return this.costo * this.Duracion;
        }
        public new string Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            return (aux.Append(base.Mostrar()).Append(this.CostoLlamada.ToString())).ToString();
        }
        #endregion
    }
}
