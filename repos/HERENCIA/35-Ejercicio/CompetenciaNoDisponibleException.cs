using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Ejercicio
{
    public class CompetenciaNoDisponibleException : Exception
    {
        /*a. La sobreescritura del método ToString retornará un mensaje con el siguiente formato por líneas:
            i. "Excepción en el método {0} de la clase {1}:"
            ii. Mensaje propio de la excepción
            iii. Todos los InnerException con una tabulación ('\t').
            b. La excepción CompetenciaNoDisponibleExcepcion será lanzada dentro de == de Competencia y Vehículo con el mensaje "El vehículo no corresponde a la competencia",
            capturada dentro del operador + y vuelta a lanzar como una nueva excepción con el mensaje "Competencia incorrecta". 
            Utilizar innerExcepcion para almacenar la excepción original.
            c. Modificar el Main para agregar un Vehículo que no corresponda con la competencia,
            capturar la excepción y mostrar el error por pantalla. 
         */
        private string nombreClase;
        private string nombreMetodo;

        #region Constructor
        public CompetenciaNoDisponibleException(string mensaje,string clase, string metodo)
        { 
        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo,Exception innerException)
        {
        }
        #endregion
        #region Propiedades
        public string NombreClase
        {
            get 
            { 
                return this.nombreClase; 
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        #endregion

    }

}
