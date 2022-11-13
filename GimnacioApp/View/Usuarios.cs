using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GimnacioApp.Model.Dao;

namespace GimnacioApp
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            VerRegistros("");
        }

        private void VerRegistros(string condicion)
        {
            UsuarioDao dao = new UsuarioDao();
            dataGridView1.DataSource = dao.verRegistros(condicion);
        }
    }
}
