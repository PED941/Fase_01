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

namespace GimnacioApp
{
    public partial class Main : Form
    {
        private int borderSize = 2;
        private Form currentchildForm;
        public Main()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(23, 32, 42);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void OpenForm(Form childform){
            label1.Enabled = false;
            label1.Visible = false;
            if (currentchildForm != null)
            {
                currentchildForm.Close();
            }
            currentchildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            childPanelForm.Controls.Add(childform);
            childPanelForm.Tag = childform;
            childPanelForm.BringToFront();
            childform.Show();
            titleForm.Text = childform.Text;
            titleForm.Visible = true;
            button1.Visible = true;
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void studentContol_Click(object sender, EventArgs e)
        {
            OpenForm(new Usuarios());
        }

        private void reports_Click(object sender, EventArgs e)
        {
            OpenForm(new Form3());
        }

        private void optionSet_Click(object sender, EventArgs e)
        {
            OpenForm(new Form4());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentchildForm.Close();
            titleForm.Visible = false;
            button1.Visible = false;
            label1.Enabled = true;
            label1.Visible = true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
