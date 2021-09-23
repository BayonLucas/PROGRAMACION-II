using System;
using System.Text;
namespace CentralitaHerencia
{
    public class LLamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #region Propiedades
        public float Duracion
        {
            get
            {
                return this.duracion;
            }   
        }
        public string NroDestino
        {
            get
            {
                return this.NroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion
        #region Constructor
        public LLamada(float duracion, string nroDestino, string nroOrigen)
        {
            if (duracion > 0 && !string.IsNullOrEmpty(nroDestino) && !string.IsNullOrEmpty(nroOrigen))
            {
                this.duracion = duracion;
                this.nroDestino = nroDestino;
                this.nroOrigen = nroOrigen;
            }
        }
        #endregion
        public string Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            return ((aux.Append(this.Duracion).Append(this.NroDestino)).Append(this.NroOrigen)).ToString();
        }
        public int

    }
    
}
