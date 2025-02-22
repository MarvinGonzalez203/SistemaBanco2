using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Clientes
    {
    
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarClientes()
        {
            string QryMostrarClientes = "exec usp_clientes_mostrar;";
            SqlDataAdapter adapter = new SqlDataAdapter(QryMostrarClientes,db_conexion.MtdAbrirConexion());
            DataTable dtMostrarClientes = new DataTable();
            adapter.Fill(dtMostrarClientes);
            db_conexion.MtdCerrarConexion();
            return dtMostrarClientes;
        }

        public void CP_mtdAgregarClientes(string Nombre, string Direccion, string Departamento, string Pais, string Categoria, string Estado)
        {
            db_conexion.MtdAbrirConexion();
            
            string Usp_Crear = "usp_clientes_crear";
            SqlCommand commInsertarClientes = new SqlCommand(Usp_Crear,db_conexion.MtdAbrirConexion());
            commInsertarClientes.CommandType = CommandType.StoredProcedure;
            
            commInsertarClientes.Parameters.AddWithValue("@Nombre", Nombre);
            commInsertarClientes.Parameters.AddWithValue("@Direccion", Direccion);
            commInsertarClientes.Parameters.AddWithValue("@Departamento", Departamento);
            commInsertarClientes.Parameters.AddWithValue("@Pais", Pais);
            commInsertarClientes.Parameters.AddWithValue("@Categoria", Categoria);
            commInsertarClientes.Parameters.AddWithValue("@Estado", Estado);

            commInsertarClientes.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();
        }

    }
}
