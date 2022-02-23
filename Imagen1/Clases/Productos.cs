using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imagen1.Clases
{
    internal class Productos
    {
        int codigoProductoP;
        string nombreProducto;
        int precioUnidad;
        int unidadEnExistencia;

        public Productos()
        {
            CodigoProductoP = 0;
            NombreProducto = string.Empty;
            PrecioUnidad = 0;
            UnidadEnExistencia = 0;

        }

        public Productos(int codigoProductoP, string nombreProducto, int precioUnidad, int unidadEnExistencia)
        {
            this.codigoProductoP = codigoProductoP;
            this.nombreProducto = nombreProducto;  
            this.precioUnidad = precioUnidad;
            this.unidadEnExistencia = unidadEnExistencia;
        }

        public int CodigoProductoP { get => codigoProductoP; set => codigoProductoP = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int PrecioUnidad { get => precioUnidad; set => precioUnidad = value; }
        public int UnidadEnExistencia { get => unidadEnExistencia; set => unidadEnExistencia = value; }


        public string xDNombreYExistencia()
        {

            return NombreProducto + " Tiene en existencia: " + UnidadEnExistencia;
        }
        public string info2()
        {

            return "Codigo de producto "+CodigoProductoP + "\r\n"+"Nombre de Producto " + NombreProducto + "\r\n"+"Precio Unitario" +PrecioUnidad + "\r\n";
        }

    }
}
