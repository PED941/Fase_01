
namespace GimnacioApp
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.optionSet = new System.Windows.Forms.Button();
            this.studentContol = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.titleForm = new System.Windows.Forms.Label();
            this.childPanelForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.childPanelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.reports);
            this.panel1.Controls.Add(this.optionSet);
            this.panel1.Controls.Add(this.studentContol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 456);
            this.panel1.TabIndex = 0;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout.Location = new System.Drawing.Point(5, 384);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(141, 60);
            this.logout.TabIndex = 5;
            this.logout.Text = "Salir";
            this.logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // reports
            // 
            this.reports.BackColor = System.Drawing.Color.Transparent;
            this.reports.FlatAppearance.BorderSize = 0;
            this.reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reports.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.reports.Image = ((System.Drawing.Image)(resources.GetObject("reports.Image")));
            this.reports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reports.Location = new System.Drawing.Point(5, 91);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(141, 60);
            this.reports.TabIndex = 4;
            this.reports.Text = "Informes";
            this.reports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reports.UseVisualStyleBackColor = false;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // optionSet
            // 
            this.optionSet.BackColor = System.Drawing.Color.Transparent;
            this.optionSet.FlatAppearance.BorderSize = 0;
            this.optionSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.optionSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.optionSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionSet.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionSet.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.optionSet.Image = ((System.Drawing.Image)(resources.GetObject("optionSet.Image")));
            this.optionSet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.optionSet.Location = new System.Drawing.Point(5, 157);
            this.optionSet.Name = "optionSet";
            this.optionSet.Size = new System.Drawing.Size(141, 60);
            this.optionSet.TabIndex = 3;
            this.optionSet.Text = "Opciones";
            this.optionSet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.optionSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.optionSet.UseVisualStyleBackColor = false;
            this.optionSet.Click += new System.EventHandler(this.optionSet_Click);
            // 
            // studentContol
            // 
            this.studentContol.BackColor = System.Drawing.Color.Transparent;
            this.studentContol.FlatAppearance.BorderSize = 0;
            this.studentContol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.studentContol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.studentContol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentContol.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentContol.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.studentContol.Image = ((System.Drawing.Image)(resources.GetObject("studentContol.Image")));
            this.studentContol.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.studentContol.Location = new System.Drawing.Point(3, 25);
            this.studentContol.Name = "studentContol";
            this.studentContol.Size = new System.Drawing.Size(141, 60);
            this.studentContol.TabIndex = 2;
            this.studentContol.Text = "Control de Alumnos";
            this.studentContol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.studentContol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.studentContol.UseVisualStyleBackColor = false;
            this.studentContol.Click += new System.EventHandler(this.studentContol_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.titleForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(149, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 25);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(726, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 25);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleForm
            // 
            this.titleForm.AutoSize = true;
            this.titleForm.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleForm.Location = new System.Drawing.Point(6, 2);
            this.titleForm.Name = "titleForm";
            this.titleForm.Size = new System.Drawing.Size(51, 23);
            this.titleForm.TabIndex = 0;
            this.titleForm.Text = "label1";
            this.titleForm.Visible = false;
            // 
            // childPanelForm
            // 
            this.childPanelForm.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.childPanelForm.Controls.Add(this.label1);
            this.childPanelForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.childPanelForm.Location = new System.Drawing.Point(149, 25);
            this.childPanelForm.Name = "childPanelForm";
            this.childPanelForm.Size = new System.Drawing.Size(761, 431);
            this.childPanelForm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 168);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gimnacio";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(910, 456);
            this.Controls.Add(this.childPanelForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.childPanelForm.ResumeLayout(false);
            this.childPanelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button studentContol;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button optionSet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titleForm;
        private System.Windows.Forms.Panel childPanelForm;
        private System.Windows.Forms.Label label1;
    }
}

