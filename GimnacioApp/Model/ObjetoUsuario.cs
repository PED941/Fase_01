using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnacioApp.Model
{
    class ObjetoUsuario
    {
        private int numero;
        private string nombre;
        private string direccion;
        private string profesion;
        private string casa;
        private string trabajo;
        private string celular;
        private string fechaNacimiento;
        private string fechaInscripcion;
        private string email;
        private string ingreso;
        private string pago;
        private bool activo;
        private int diasExtra;

        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public string Casa { get => casa; set => casa = value; }
        public string Trabajo { get => trabajo; set => trabajo = value; }
        public string Celular { get => celular; set => celular = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string FechaInscripcion { get => fechaInscripcion; set => fechaInscripcion = value; }
        public string Email { get => email; set => email = value; }
        public string Ingreso { get => ingreso; set => ingreso = value; }
        public string Pago { get => pago; set => pago = value; }
        public bool Activo { get => activo; set => activo = value; }
        public int DiasExtra { get => diasExtra; set => diasExtra = value; }

    }
}
