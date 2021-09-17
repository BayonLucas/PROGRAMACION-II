using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Ejercicio
{
    public class Competencia
    {
        public enum tipoCompetencia { F1, MotoCross };
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private tipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, tipoCompetencia tipoCompetencia) : this()
        {
            if (cantidadVueltas > 0 && cantidadCompetidores >= 0)
            {
                this.CantidadVueltas = cantidadVueltas;
                this.CantidadCompetidores = cantidadCompetidores;
            }
        }
        #region Propiedades
        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                if (value > 0)
                {
                    this.cantidadCompetidores = value;
                }
            }
        }
        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                if (value > 0)
                {
                    this.cantidadVueltas = value;
                }
            }
        }
        public tipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                if (value == tipoCompetencia.F1 || value == tipoCompetencia.MotoCross)
                {
                    this.tipo = value;
                }
            }
        }
        #endregion
        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Cantidad de vueltas en la competencia: {this.CantidadVueltas}");
            stringBuilder.AppendLine($"Cantidad de competidores: {this.CantidadCompetidores}");
            //Imprimimos luego todos los competidores
            if (this.Tipo == tipoCompetencia.F1)
            {
                foreach (AutoF1 item in this.competidores)
                {
                    stringBuilder.AppendLine(item.MostrarDatos());
                    stringBuilder.AppendLine(item.MostrarDatos());
                }
            }
            else
            {
                if (this.Tipo == tipoCompetencia.MotoCross)
                {
                    foreach (MotoCross item in this.competidores)
                    {
                        stringBuilder.AppendLine(item.MostrarDatos());
                        stringBuilder.AppendLine(item.MostrarDatos());
                    }
                }
            }
            return stringBuilder.ToString();
        }
        #region Sobrecarga - & + (agregar/quitar competidores a la competencia)
        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            if (c == v)
            {
                return c.competidores.Remove(v);
            }
            return false;
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            if(c.competidores.Count < c.CantidadCompetidores && c != v)        //si hay espacio y el competidor no forma parte de la lista...
            {
                c.competidores.Add(v);
                v.EnCompetencia = true;
                v.VueltasRestantes = (c.CantidadVueltas);
                Random auxRandom = new Random();
                int auxCombustible = auxRandom.Next((int)15, (int)100);
                v.CantidadCombustible = ((short)auxCombustible);
                return true;
            }
            return false;
        }
        #endregion
        #region Sobrecarga == & !=
        public static bool operator ==(Competencia c, VehiculoDeCarrera competidor)     
        {

            /*g. Si la competencia es declarada del tipo CarreraMotoCross, sólo se podrán agregar vehículos
                del tipo MotoCross.
            Si la competencia es del tipo F1, sólo se podrán agregar objetos AutoF1.
                Colocar dicha comparación dentro del == de la clase Competencia.      
             */
            //Comparo el tipo de competencia con el tipo de vehiculo
            //                    == VehiculoDeCarrera            
            bool aux = c.Tipo.Equals(competidor);

            /*
            if (c.Tipo.ToString() == competidor.GetType().ToString())
            {

            }
            else
            {
                if(c.Tipo == tipoCompetencia.MotoCross)
                {

                }
            }
            foreach (VehiculoDeCarrera item in c.competidores)
            {
                if(item == competidor) //Si el competidor se encuentra o no en la competeencia
                {
                    return true;
                }
            }
            */
            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }
        #endregion
    }   
}
