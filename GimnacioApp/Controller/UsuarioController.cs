using GimnacioApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GimnacioApp.Controller
{
    class UsuarioController : Conexion
    {
        //metodos crud
        
        SqlCommand comando = new SqlCommand();
        public BindingList<ObjetoUsuario> verRegistros()
        {
            SqlDataReader leerFilas;
            comando.Connection = conexion;
            comando.CommandText = "select [cli_numero],[cli_nombre],[cli_direccion],[cli_profesion] ,[cli_casa],[cli_trabajo],[cli_celular],[cli_nac],[cli_inscripcion],[cli_email],[cli_ingreso],[cli_pago],[cli_activo],[cli_diasextras] from [dbo].[cliente]";

            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            leerFilas = (comando.ExecuteReader());

            BindingList<ObjetoUsuario> listaProvisional = new BindingList<ObjetoUsuario>();
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
                comando.Parameters.Clear();
            }
            leerFilas.Close();
            conexion.Close();

            return listaProvisional;
        }

        public string eliminarRegistro(ObjetoUsuario usuario)
        {
            String mensaje;
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE [dbo].[cliente] WHERE [cli_numero]=@Numero AND [cli_activo]=@Activo";
            comando.Parameters.AddWithValue("@Activo", 0);
            comando.Parameters.AddWithValue("@Numero", usuario.Numero);
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
                conexion.Close();
                mensaje = "Eliminacion Completada";

            }
            catch (SqlException e)
            {
                mensaje = e.Message.ToString();
            }
            return mensaje;
        }

        public string modificarRegistro(ObjetoUsuario usuario)
        {
            String mensaje;
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE [dbo].[cliente] SET [cli_nombre]=@Nombre,[cli_direccion]=@Direccion,[cli_profesion]=@Profesion,[cli_casa]=@Casa,[cli_trabajo]=@Trabajo,[cli_celular]=@Celular,[cli_nac]=@FechaNacimiento,[cli_inscripcion]=@FechaInscripcion,[cli_email]=@Email,[cli_ingreso]=@Ingreso,[cli_pago]=@Pago,[cli_activo]=@Activo,[cli_diasextras]=@DiasExtra WHERE [cli_numero]=@Numero";
            comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@Direccion", usuario.Direccion);
            comando.Parameters.AddWithValue("@Profesion", usuario.Profesion);
            comando.Parameters.AddWithValue("@Casa", usuario.Casa);
            comando.Parameters.AddWithValue("@Trabajo", usuario.Trabajo);
            comando.Parameters.AddWithValue("@Celular", usuario.Celular);
            comando.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
            comando.Parameters.AddWithValue("@FechaInscripcion", usuario.FechaInscripcion);
            comando.Parameters.AddWithValue("@Email", usuario.Email);
            comando.Parameters.AddWithValue("@Ingreso", usuario.Ingreso);
            comando.Parameters.AddWithValue("@Pago", usuario.Pago);
            comando.Parameters.AddWithValue("@Activo", usuario.Activo);
            comando.Parameters.AddWithValue("@DiasExtra", usuario.DiasExtra);
            comando.Parameters.AddWithValue("@Numero", usuario.Numero);
            try
            {
                if (conexion.State == ConnectionState.Closed) { 
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
                conexion.Close();
                mensaje = "Modificacion Completada";

            }
            catch (SqlException e)
            {
                mensaje = e.Message.ToString();
            }
            return mensaje;
        }

        public string crearRegistro(ObjetoUsuario usuario)
        {
            String mensaje;
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO [dbo].[cliente] ([cli_nombre],[cli_direccion],[cli_profesion],[cli_casa],[cli_trabajo],[cli_celular],[cli_nac],[cli_inscripcion],[cli_email],[cli_ingreso],[cli_pago],[cli_activo],[cli_diasextras]) VALUES(@Nombre,@Direccion,@Profesion,@Casa,@Trabajo,@Celular,@FechaNacimiento,@FechaInscripcion,@Email,@Ingreso,@Pago,@Activo,@DiasExtra)";
            comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@Direccion", usuario.Direccion);
            comando.Parameters.AddWithValue("@Profesion", usuario.Profesion);
            comando.Parameters.AddWithValue("@Casa", usuario.Casa);
            comando.Parameters.AddWithValue("@Trabajo", usuario.Trabajo);
            comando.Parameters.AddWithValue("@Celular", usuario.Celular);
            comando.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
            comando.Parameters.AddWithValue("@FechaInscripcion", usuario.FechaInscripcion);
            comando.Parameters.AddWithValue("@Email", usuario.Email);
            comando.Parameters.AddWithValue("@Ingreso", usuario.Ingreso);
            comando.Parameters.AddWithValue("@Pago", usuario.Pago);
            comando.Parameters.AddWithValue("@Activo", usuario.Activo);
            comando.Parameters.AddWithValue("@DiasExtra", usuario.DiasExtra);

            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
                conexion.Close();
                mensaje = "Insersion Completada ";
                
            }catch(SqlException e)
            {
                mensaje = e.Message.ToString();
            }
            return mensaje;
        }

        public BindingList<IngresosModel> verRegistros(ObjetoUsuario usuario)
        {
            SqlDataReader leerFilas;
            comando.Connection = conexion;
            comando.CommandText = "select * from [dbo].[ingresos] where [ing_cliente]=@NumeroUsuario";
            comando.Parameters.AddWithValue("@NumeroUsuario", usuario.Numero);

            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            leerFilas = comando.ExecuteReader();

            BindingList<IngresosModel> listaProvisional = new BindingList<IngresosModel>();
            while (leerFilas.Read())
            {
                listaProvisional.Add(new IngresosModel
                {
                    Numero = leerFilas.GetInt32(0),
                    Cliente = leerFilas.GetString(1),
                    Fecha = leerFilas.GetString(2),
                    Hora = leerFilas.GetString(3)
                });
            }
            leerFilas.Close();
            conexion.Close();

            return listaProvisional;
        }

    }
}
