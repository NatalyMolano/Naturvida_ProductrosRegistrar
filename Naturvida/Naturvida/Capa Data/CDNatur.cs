using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naturvida.Recursos
{
    public class CDNatur : IFunciones
    {
        string CadenaConexion = "Server=localhost;User=root;Password=admid;Port=3306;database=newschema";
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }

        public int Cantidad { get; set; }
        public MySqlConnection Connection { get; private set; }


        public CDNatur(int _codigo, string _nombre, string _descripcion, int _valor, int _cantidad)
        {
            this.Codigo = _codigo;
            this.Nombre = _nombre;
            this.Descripcion = _descripcion;
            this.Valor = _valor;
            this.Cantidad = _cantidad;
        }
        public int Registrar()
        {
            int Estado = 0;
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);

            try
            {
                using (var Command = new MySqlCommand("SP_RegistrarProducto", mySqlConnection))
                {
                    Command.Parameters.AddWithValue("Codigo", this.Codigo);
                    Command.Parameters.AddWithValue("Descripcion", this.Descripcion);
                    Command.Parameters.AddWithValue("Valor", this.Valor);
                    Command.Parameters.AddWithValue("Cantidad", this.Cantidad);
                    Command.Parameters.AddWithValue("Nombre", this.Nombre);
                    Command.CommandType = CommandType.StoredProcedure;
                    mySqlConnection.Open();
                    Command.ExecuteNonQuery();
                    mySqlConnection.Close();
                }
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                Estado = 1;
            }

            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();

                }

            }
            return Estado;
        }

        bool IFunciones.Actualizar()
        {
            throw new NotImplementedException();
        }

        DataTable IFunciones.BuscarPorCodigo(int id)
        {
            throw new NotImplementedException();
        }

        bool IFunciones.Eliminar()
        {
            throw new NotImplementedException();
        }

        public DataSet Listar()
        {
            throw new NotImplementedException();
        }

        /*public DataSet Listar()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "";
            MySqlDataAdapter Adaptador;
            DataSet dataSet = new DataSet();

            Adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            Adaptador.Fill(dataSet, "tbl");

            return dataSet;

            /*var tabla = new DataTable();
            try
            {
                using(var adaptador = new MySqlDataAdapter("Select * from productos", Connection))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return tabla;*/
    }
}

         
 


