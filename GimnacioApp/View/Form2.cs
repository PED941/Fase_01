using GimnacioApp.Controller;
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

namespace GimnacioApp
{
    public partial class Form2 : Form
    {
        BindingList<IngresosModel> ingresoSource = new BindingList<IngresosModel>();
        ObjetoUsuario userData = new ObjetoUsuario();
        UsuarioController dao = new UsuarioController();
        public Form2(ObjetoUsuario usuario)
        {
            InitializeComponent();
            userData = usuario;
            VerRegistros(usuario);
            dataGridView1.DataSource = ingresoSource;
        }
        private void VerRegistros(ObjetoUsuario usuario)
        {
            dataGridView1.DataSource = null;
            ingresoSource = dao.verRegistros(usuario);
            dataGridView1.DataSource = ingresoSource;
        }

        private void regUserButtom_Click(object sender, EventArgs e)
        {
            String mesaje = dao.crearRegistroIngreso(userData);
            VerRegistros(userData);
            MessageBox.Show(mesaje);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
