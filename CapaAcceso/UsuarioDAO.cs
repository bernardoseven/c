using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaAcceso
{
    public class UsuarioDAO
    {
        string connStr = @"Server=SCE_LAB0202;Database=Natalia;Trusted_Connection=true;";
        public bool IsUsuario(Veterinario _v)
        {

            String query = "select * from USUARIO where pass = '" + _v.Password + "';";
            
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader sreader = command.ExecuteReader();
                while (sreader.Read())
                {
                    return true;
                }
            }
            return false;
        }

        public bool InsertarVeterinario(Usuario _usuario)
        {
            
            String query = "INSERT INTO VETERINARIO VALUES (" +
               "'" + _usuario.Rut + "'," +
                "'" + _usuario.Nombre + "'," +
                "'" + _usuario.ApPaterno + "'," +
                "'" + _usuario.ApMaterno + "'," +
                "'" + _usuario.Fijo + "'," +
                "'" + _usuario.Celular + "'," +
                "'" + _usuario.Email + "'," +
                "'" + _usuario.FechaIngreso + "'," +
                "'" + _usuario.Especialidad + "'," +
                //"'" + _usuario.foto + "'," + falta ingresar foto
                 ");";


            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception s)
            {
                return false;
            }

         


        }
    }
}
