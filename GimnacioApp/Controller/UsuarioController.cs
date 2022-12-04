using GimnacioApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GimnacioApp.Controller
{
    class UsuarioController : Conexion
    {
            //metodos crud
            SqlDataReader leerFilas;
            SqlCommand comando = new SqlCommand();
            public List<ObjetoUsuario> verRegistros(string condicion)
            {
                comando.Connection = conexion;
                comando.CommandText = "select * from [dbo].[cliente]";

                conexion.Open();

                leerFilas = comando.ExecuteReader();

                List<ObjetoUsuario> listaProvisional = new List<ObjetoUsuario>();
                while (leerFilas.Read())
                {
                    listaProvisional.Add(new ObjetoUsuario
                    {
                        Numero = leerFilas.GetInt32(0),
                        Nombre = leerFilas.GetString(1),
                        Direccion = leerFilas.GetString(2),
                        Profesion = leerFilas.GetString(3),
                        Casa = leerFilas.GetString(4),
                        Trabajo = leerFilas.GetString(5),
                        Celular = leerFilas.GetString(6),
                        FechaNacimiento = leerFilas.GetString(7),
                        FechaInscripcion = leerFilas.GetString(8),
                        Email = leerFilas.GetString(9),
                        Ingreso = leerFilas.GetString(10),
                        Pago = leerFilas.GetString(11),
                        Activo = (bool)leerFilas.GetSqlBoolean(12),
                        DiasExtra = leerFilas.GetInt32(13)
                    });
                }
                leerFilas.Close();
                conexion.Close();

                return listaProvisional;
            }

    }
}
