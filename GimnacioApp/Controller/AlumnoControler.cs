using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using GimnacioApp.Model;

namespace GimnacioApp.Controller
{
    class AlumnoControler:Conexion
    {
        
        SqlCommand Comando = new SqlCommand();

        public void ingresarRegistro(AlumnoModel alumno)
        {
            Comando.Connection = conexion;
            Comando.CommandText = "insert into alumnos values ('"+ alumno.Carnet + "','" + alumno.Nombres + "','" + alumno.Apellidos + "','" + alumno.Carrera + "','" + alumno.Contrasena + "')";
            Comando.ExecuteNonQuery();
        }

    }
}
