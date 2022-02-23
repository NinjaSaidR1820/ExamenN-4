using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imagen1.Clases;
using Imagen1.Formularios;

namespace Imagen1.Formularios
{
    public partial class AgregarDatos : Form
    {
        List<Clientes> listaClientes = new List<Clientes>();
        List<Pedidos> listaPedidos = new List<Pedidos>();
        List<Productos> listaProductos = new List<Productos>();

        Clientes clientes;
        Pedidos pedidos;
        Productos productos;


        int Unidades = 0;
        int PrecioProduct = 0;

        public AgregarDatos()
        {

            InitializeComponent();
        }

        public void guardarCliente()
        {
            clientes = new Clientes(int.Parse(txtCodigoCliente.Text),txtNombreCliente.Text, txtApellidoCliente.Text);

            listaClientes.Add(clientes);

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaClientes;
        }
        public void guardarPedido()
        {
            pedidos = new Pedidos(int.Parse(txtCodigoProduct.Text), int.Parse(txtCodigoVenta.Text), int.Parse(txtCodigoCliente2.Text), int.Parse(txtCantidad.Text), DtpFecha.Value);
            listaPedidos.Add(pedidos);

            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = listaPedidos;
        }
        public void guardarProducto()
        {
            productos = new Productos(int.Parse(txtCodigoProduct.Text),txtNombreProducto.Text, int.Parse(txtPrecioUnidad.Text),int.Parse(txtUnidadExistencia.Text) );

            listaProductos.Add(productos);

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;
        }
        
       

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarDatos_Load(object sender, EventArgs e)
        {

        }

        #region Botones
        private void btnIngresarPedido_Click(object sender, EventArgs e)
        {
            this.progressBar1.Visible = true;
            this.timer1.Start();
            guardarPedido();
            GetSubTotal();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            this.progressBar2.Visible = true;
            this.timer1.Start();
            guardarCliente();
        }
        
        private void btnIngresarProductos_Click(object sender, EventArgs e)
        {
            this.progressBar3.Visible = true;
            this.timer1.Start();
            guardarProducto();
        }

        #endregion



        #region LINQ

        public void nombreyExistencia()
        {

            IEnumerable<Productos> nom = from d in listaProductos select d;

            foreach (Productos d in nom)
            {

                txtCONSULTA.AppendText(d.xDNombreYExistencia());
            }
        }


        public void Factura()
        {

            IEnumerable<Productos> nom = from d in listaProductos select d;
            IEnumerable<Pedidos> nom2 = from d in listaPedidos select d;
            IEnumerable<Clientes> nom3 = from d in listaClientes select d;

            foreach (Clientes i in nom3)
            {
                txtCONSULTA.AppendText(i.info1());

            }
            foreach (Productos i in nom)
            {
                txtCONSULTA.AppendText(i.info2());

            }
            foreach (Pedidos i in nom2)
            {
                txtCONSULTA.AppendText(i.info3());

            }
        }


        #endregion




        public void GetSubTotal()
        {
            

            IEnumerable<Productos> sub = from d in listaProductos select d;
            IEnumerable<Pedidos> sub2 = from s in listaPedidos select s;

            foreach(var i in sub)
            {
                PrecioProduct = i.PrecioUnidad;

            }

            foreach (var e in sub2)
            {
                Unidades = e.Cantidad;

            }



            int SubTotal;
            
            SubTotal = Unidades * PrecioProduct ;


            MessageBox.Show("El Subtotal del Cliente es de :" + SubTotal);
            
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            GetSubTotal();
        }

        private void rbExistenciaYNombre_CheckedChanged(object sender, EventArgs e)
        {

            txtCONSULTA.Clear();
            nombreyExistencia();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(8);
            if(progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {
            
        }

        private void rbFactura_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            Factura();
        }
    }
}
