using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {

        //l.CalcularGanancia será privado.
        //Este método recibe un Enumerado TipoLlamada y retornará el valor de lo recaudado,
        //según el criterio elegido
        //(ganancias por las llamadas del tipo Local,Provincial o de Todas según corresponda).

        //m.El método Mostrar expondrá
        //la razón social,
        //la ganancia total,
        //ganancia por llamados locales y provinciales y
        //el detalle de las llamadas realizadas.

        //n.La lista sólo se inicializará en el constructor por defecto Centralita().

        //o.Las propiedades GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial
        //retornarán el precio de lo facturado según el criterio.
        //Dichos valores se calcularán en el método CalcularGanancia().
        public enum TipoLlamada { Local, Provincial };
        private List<LLamada> listaDeLLamadas;
        protected string razonSocial;
        #region Constructores
        public Centralita()
        {
            this.listaDeLLamadas = new List<LLamada>();
        }
        public Centralita(List<LLamada> listaDeLLamadas, string razonSocial) : this()
        {
            if(!string.IsNullOrWhiteSpace(razonSocial))
            {
                this.razonSocial = razonSocial;
            }            
        }
        #endregion    
        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }

        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial)+ this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public List<LLamada> Llamadas
        {
            get
            {
                return this.listaDeLLamadas;
            }
        }
        #endregion
        #region Metodos
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float auxTotalCosto = 0;
            foreach (LLamada item in this.Llamadas)
            {
                if(tipo == TipoLlamada.Local)
                {
                    if(item.GetType() ==  typeof(Local))
                    {
                        auxTotalCosto += ((Local)item).CostoLlamada;
                    }
                }
                else if(tipo == TipoLlamada.Provincial)
                {
                    if (item.GetType() == typeof(Provincial))
                    {
                        auxTotalCosto += ((Provincial)item).CostoLlamada;
                    }
                }
            }
            return auxTotalCosto;
        }
        public string Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            aux.Append(this.razonSocial).Append(this.GananciasPorTotal).Append(this.GananciasPorLocal).Append(this.GananciasPorProvincial);
            //modifcar
            foreach (LLamada item in this.Llamadas)
            {
                if (item.GetType() == typeof(Provincial))
                {
                    aux.Append(((Provincial)item).Mostrar());
                }
                else if(item.GetType() == typeof(Local))
                {
                    aux.Append(((Local)item).Mostrar());
                }
            }
            return aux.ToString();
        }

        public void OrdenarLLamadas()
        {
                
                this.Llamadas.Sort(LLamada.OrdenarPorDuracion);
        }
        #endregion

    }
}
