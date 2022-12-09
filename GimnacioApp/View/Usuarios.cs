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
using GimnacioApp.Model;

namespace GimnacioApp
{
    public partial class Usuarios : Form
    {
        BindingList<ObjetoUsuario> usuarioSource = new BindingList<ObjetoUsuario>();
        ObjetoUsuario usuario = new ObjetoUsuario();
        UsuarioController dao = new UsuarioController();
        string state;

        public Usuarios()
        {
            InitializeComponent();
            usuarioSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.listOfParts_ListChanged);
            VerRegistros();
            dataGridView1.DataSource = usuarioSource;
        }

        private void listOfParts_ListChanged(object sender, ListChangedEventArgs e)
        {
            state =e.ListChangedType.ToString();
        }

        private void VerRegistros()
        {
            usuarioSource = dao.verRegistros();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
                usuario = (ObjetoUsuario)dataGridView1.SelectedRows[0].DataBoundItem;
                string message = dao.crearRegistro(usuario);
                VerRegistros();
                dataGridView1.DataSource = usuarioSource;
                MessageBox.Show(message);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
                usuario = (ObjetoUsuario)dataGridView1.SelectedRows[0].DataBoundItem;
                string message = dao.eliminarRegistro(usuario);
                VerRegistros();
                dataGridView1.DataSource = usuarioSource;
                MessageBox.Show(message);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            usuario = (ObjetoUsuario)dataGridView1.SelectedRows[0].DataBoundItem;
            string message = dao.modificarRegistro(usuario);
            MessageBox.Show(message);
        }

        private void buttonIngresos_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectionMode==false) { 
                usuario = (ObjetoUsuario)dataGridView1.SelectedRows[0].DataBoundItem;
                Form2 frmClient = new Form2(usuario);
                frmClient.WindowState = FormWindowState.Normal;
                frmClient.Show();
            }
            else
            {
                MessageBox.Show("No se a seleccionado ningun cliente");
            }
        }
    }
}
