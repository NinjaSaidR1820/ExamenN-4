using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imagen1.Clases
{
    internal class Clientes
    {
        int codigoCliente;
        string nombreCliente;
        string apellidoCliente;

        public Clientes()
        {

            CodigoCliente = 0;
            NombreCliente = string.Empty;
            ApellidoCliente = string.Empty;

        }


        public Clientes(int codigoCliente, string nombreCliente, string apellidoCliente)
        {
            this.codigoCliente = codigoCliente;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
           
        }

        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; } 
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }


        public string info1()
        {

            return "Codigo de Cliente "+CodigoCliente +"\r\n" + "Nombre " + NombreCliente + " "+ApellidoCliente+ "\r\n";

        }
       
    }
}
