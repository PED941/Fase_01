using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnacioApp.Model
{
    class AlumnoModel
    {
        int _Id;
        string _Carnet;
        string _Nombres;
        string _Apellidos;
        string _Carrera;
        string _Contrasena;

        public int Id { get => _Id; set => _Id = value; }
        public string Carnet { get => _Carnet; set => _Carnet = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }
    }
}
