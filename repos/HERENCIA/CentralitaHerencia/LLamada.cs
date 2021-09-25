using System;
using System.Text;
namespace CentralitaHerencia
{
    
    public class LLamada
    {
        public enum TipoLlamada { Local, Provincial, Todas };
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
        #region Metodos
        public string Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            return ((aux.Append(this.Duracion).Append(this.NroDestino)).Append(this.NroOrigen)).ToString();
        }
        /// <summary>
        /// Compara por duracion de llamada dos llamdas
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns>Retorna 1 si A>B, 2 si A<B o 0 si A=B</returns>
        public static int OrdenarPorDuracion(LLamada llamada1,LLamada llamada2)
        {
            //reotrnar 
            if(llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }
            else if(llamada1.Duracion < llamada2.Duracion)
            {
                return -1;
            }
            return 0;            
        }
        #endregion

    }
    
}
