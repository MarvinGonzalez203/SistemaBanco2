﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Cuentas
    {
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarCuentas()
        {
            string QryMostrarCuentas = "EXEC usp_cuentas_mostrar";
            SqlDataAdapter adapter = new SqlDataAdapter(QryMostrarCuentas, db_conexion.MtdAbrirConexion());
            DataTable dtMostrarCuentas = new DataTable();
            adapter.Fill(dtMostrarCuentas);
            db_conexion.MtdCerrarConexion();
            return dtMostrarCuentas;
        }

        public void MtdAgregarCuentas(String CodigoCliente, String NumeroCuenta, String Saldo, String FechaApertura, String TipoCuenta, String Estado)
        {

            string Usp_Crear = "usp_Cuentas_crear";
            SqlCommand cmd_InsertarCuentas = new SqlCommand(Usp_Crear, db_conexion.MtdAbrirConexion());

            cmd_InsertarCuentas.CommandType = CommandType.StoredProcedure;

            cmd_InsertarCuentas.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);
            cmd_InsertarCuentas.Parameters.AddWithValue("@NumeroCuenta", NumeroCuenta);
            cmd_InsertarCuentas.Parameters.AddWithValue("@Saldo", Saldo);

            cmd_InsertarCuentas.Parameters.AddWithValue("@FechaApertura", FechaApertura);
            cmd_InsertarCuentas.Parameters.AddWithValue("@TipoCuenta", TipoCuenta);
            cmd_InsertarCuentas.Parameters.AddWithValue("@Estado", Estado);

            cmd_InsertarCuentas.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();


        }

    }
}
