using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentralitaExcepcion : Exception
    {
        /*Agregar la clase CentralitaException, la cual deriva de Exception.
            b. En el operador + de Centralita, lanzar la excepción CentralitaExcepction en el caso de que la
            llamada se encuentre registrada en el sistema.
            c. Capturar dicha excepción tanto en la versión para Consola como en la de Formularios y
            mostrar el mensaje de forma “amigable” al usuario.
         */
        private string nombreClase;
        private string nombreMetodo;

        public CentralitaExcepcion(string mensaje, string clase, string metodo)
        {

        }
        public CentralitaExcepcion(string mensaje, string clase, string metodo,Exception innerException)
        {

        }
    }
}
