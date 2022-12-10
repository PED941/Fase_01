using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimnacioApp.View
{
    public partial class pagos : Form
    {


        public pagos()
        {
            InitializeComponent();
        }

        private void regresarBtn_Click(object sender, EventArgs e)
        {

            Main menuprincipal = new Main();
            this.Hide();
            menuprincipal.Show();
        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
