using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imagen1.Clases
{
    public class Pedidos
    {

        int codigoProducto;
        int codigoVenta;
        int codigoCliente;
        int cantidad;
        
        DateTime fechaDeVenta;

        public Pedidos()
        {
           CodigoProducto = 0;
            CodigoVenta = 0;
            CodigoCliente = 0;
           Cantidad = 0;
            FechaDeVenta = DateTime.MaxValue;

        }

        public Pedidos(int codigoproduct, int codigoventa, int codigocliente, int cantidad,DateTime fecha)
        {
            this.CodigoProducto = codigoproduct;
            this.CodigoVenta = codigoventa;
            this.CodigoCliente = codigocliente;
            this.Cantidad = cantidad;
            this.FechaDeVenta = fecha;

        }

        public int CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public int CodigoVenta { get => codigoVenta; set => codigoVenta = value; }
        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        
        public DateTime FechaDeVenta { get => fechaDeVenta; set => fechaDeVenta = value; }

        public string info3()
        {

            return CodigoVenta + " " + Cantidad + " " + FechaDeVenta;
        }

    }
}
