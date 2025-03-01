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

        public void MtdActualizarClientes(int Codigo, string Nombre, string Direccion, string Departamento, string Pais, string Categoria, string Estado)
        {
            string usp_actualizar = "usp_clientes_editar";
            SqlCommand cmdUspActualizar = new SqlCommand(usp_actualizar, db_conexion.MtdAbrirConexion());
            cmdUspActualizar.CommandType = CommandType.StoredProcedure;


            cmdUspActualizar.Parameters.AddWithValue("@Codigo", Codigo);
            cmdUspActualizar.Parameters.AddWithValue("@Nombre", Nombre);
            cmdUspActualizar.Parameters.AddWithValue("@Direccion", Direccion);
            cmdUspActualizar.Parameters.AddWithValue("@Departamento", Departamento);
            cmdUspActualizar.Parameters.AddWithValue("@Pais", Pais);
            cmdUspActualizar.Parameters.AddWithValue("@Categoria", Categoria);
            cmdUspActualizar.Parameters.AddWithValue("@Estado", Estado);

            cmdUspActualizar.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();


        }

        public void MtdEliminar(int Codigo)
        {
            string usp_eliminar = "usp_clientes_eliminar";
            SqlCommand cmdUsEliminar = new SqlCommand(usp_eliminar, db_conexion.MtdAbrirConexion());
            cmdUsEliminar.CommandType = CommandType.StoredProcedure;
            cmdUsEliminar.Parameters.AddWithValue("@Codigo", Codigo);
            cmdUsEliminar.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();
        }

    }
}
