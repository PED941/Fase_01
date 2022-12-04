using GimnacioApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimnacioApp.View
{
    public partial class CrearAlumno : Form
    {
        public CrearAlumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjetoUsuario usuario = new ObjetoUsuario();
            usuario.Nombre = textBox1.ToString();
            usuario.Direccion = textBox2.ToString();
            usuario.Profesion = textBox2.ToString();
            usuario.Casa = textBox2.ToString();
            usuario.Trabajo = textBox2.ToString();
            usuario.Celular = textBox2.ToString();
            usuario.FechaNacimiento = textBox2.ToString();
            usuario.FechaInscripcion = textBox2.ToString();
            usuario.Email = textBox2.ToString();
            usuario.Ingreso = textBox2.ToString();
            usuario.Pago = textBox2.ToString();
            usuario.Activo = true;
            usuario.DiasExtra = int.Parse(textBox2.ToString());
        }
    }
}
