using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnacioApp.Model
{
    public class IngresosModel
    {
        private int numero;
        private string cliente;
        private string fecha;
        private string hora;

        public int Numero { get => numero; set => numero = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
