using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GimnacioApp.Controller;


namespace GimnacioApp
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            VerRegistros("");
        }

        private void VerRegistros(string condicion)
        {
            UsuarioController dao = new UsuarioController();
            dataGridView1.DataSource = dao.verRegistros(condicion);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
