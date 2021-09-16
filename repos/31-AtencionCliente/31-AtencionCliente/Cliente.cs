using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_AtencionCliente
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(string nombre, int numero)
        {
            this.Nombre = nombre;
            this.Numero = numero;
        }

        public string Nombre 
        {
            get
            {
                return nombre;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
                 
            }
        
        }
        public int Numero { get => numero; set => numero = value; }
    }
}
