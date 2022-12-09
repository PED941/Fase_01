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
        //ObjetoUsuario usuario = new ObjetoUsuario();
        UsuarioController dao = new UsuarioController();
        public Form2(ObjetoUsuario usuario)
        {
            InitializeComponent();
            VerRegistros(usuario);
            dataGridView1.DataSource = ingresoSource;
        }
        private void VerRegistros(ObjetoUsuario usuario)
        {
            ingresoSource = dao.verRegistros(usuario);
        }

    }
}
