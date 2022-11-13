using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace GimnacioApp.Model.Dao
{
    class DBContext
    {
        protected SqlConnection Conexion = new SqlConnection("Server=DESKTOP-QOOD7NP;DataBase=ProyectoPED;Integrated Security=true");
    }
}
