using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace EjemploForms
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = almacen; Uid = root; Pwd = root; Port = 3306");
        }

        public DataTable getClientes()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuariosalmacen", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable clientes = new DataTable();
                clientes.Load(resultado);
                conexion.Close();
                return clientes;

            }
            catch(MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getClientesPorNombre(String nombre)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuariosalmacen WHERE DNI='" + nombre +"'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable clientes = new DataTable();
                clientes.Load(resultado);
                conexion.Close();
                return clientes;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
