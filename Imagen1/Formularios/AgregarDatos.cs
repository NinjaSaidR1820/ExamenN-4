﻿using System;
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
            guardarPedido();
            GetSubTotal();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            guardarCliente();
        }
        
        private void btnIngresarProductos_Click(object sender, EventArgs e)
        {

            guardarProducto();
        }

        #endregion


        #region LINQ




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
    }
}
