using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnacioApp.Controller
{
    public class Conexion
    {
        protected SqlConnection conexion = new SqlConnection("Server=DESKTOP-J307FUC/SQLEXPRESS;DataBase=Fase1_test; Integrated Security=true");
    }
}
