using System;
using Naturvida;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naturvida
{
    public partial class frmProductos : Form
    {
        string CadenaConexion = "Server=localhost;User=root;Password=admid;Port=3306;database=db_naturvida";
        public frmProductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsertar.Visible = true;
            pnlModificar.Visible = false;
            pnleliminar.Visible = false;
            pnlconfigurar.Visible = false;
        }

        private void gestionarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsertar.Visible = false;
            pnlModificar.Visible = false;
            pnleliminar.Visible = false;
            pnlconfigurar.Visible = true;
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsertar.Visible = false;
            pnlModificar.Visible = true;
            pnleliminar.Visible = false;
            pnlconfigurar.Visible = false;
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsertar.Visible = false;
            pnlModificar.Visible = false;
            pnleliminar.Visible = true;
            pnlconfigurar.Visible = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            PruebaConexion();
            /*var Productos = new Recursos.CDNatur();
            var Tabla = Productos.Listar();
            var NumeroFilas = Tabla.Rows.Count;
            if(NumeroFilas > 0)
            {
                for (int i =0; i <NumeroFilas; i++)
                {
                    String Codigo = Tabla.Rows[i][0].ToString();
                    String Descripcion = Tabla.Rows[i][2].ToString();
                    String Nombre = Tabla.Rows[i][2].ToString();
                    String Valor = Tabla.Rows[i][3].ToString();
                    String Cantidad = Tabla.Rows[i][4].ToString();

                    dataGridView1.Rows.Add(Codigo,Nombre,Descripcion,Valor,Cantidad);
                }
            }*/
        }
        public void PruebaConexion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            try
            {
                mySqlConnection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Conectarse " + ex.Message);
                return;
            }
            MessageBox.Show("Conectado");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var RegistrarProducto = new Recursos.CDNatur(Convert.ToInt16(txtCodigo.Text.Trim()), txtNombre.Text, txtDescripcion.Text, Convert.ToInt16(txtValor.Text.Trim()), Convert.ToInt16(txtCantidad.Text.Trim()));
            RegistrarProducto.Registrar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtCodigo.Clear();
            txtValor.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }

}
