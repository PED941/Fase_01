
namespace GimnacioApp.View
{
    partial class pagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EstadoBtn = new System.Windows.Forms.TextBox();
            this.verEstadoBtn = new System.Windows.Forms.Button();
            this.regresarBtn = new System.Windows.Forms.Button();
            this.salirbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(773, 508);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(251, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(822, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado del usuario";
            // 
            // EstadoBtn
            // 
            this.EstadoBtn.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoBtn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.EstadoBtn.Location = new System.Drawing.Point(831, 242);
            this.EstadoBtn.Name = "EstadoBtn";
            this.EstadoBtn.Size = new System.Drawing.Size(260, 43);
            this.EstadoBtn.TabIndex = 3;
            this.EstadoBtn.Text = "Estado";
            // 
            // verEstadoBtn
            // 
            this.verEstadoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verEstadoBtn.BackgroundImage")));
            this.verEstadoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.verEstadoBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verEstadoBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.verEstadoBtn.Location = new System.Drawing.Point(903, 342);
            this.verEstadoBtn.Name = "verEstadoBtn";
            this.verEstadoBtn.Size = new System.Drawing.Size(126, 55);
            this.verEstadoBtn.TabIndex = 4;
            this.verEstadoBtn.Text = "Ver";
            this.verEstadoBtn.UseVisualStyleBackColor = true;
            // 
            // regresarBtn
            // 
            this.regresarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regresarBtn.BackgroundImage")));
            this.regresarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regresarBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.regresarBtn.Location = new System.Drawing.Point(903, 420);
            this.regresarBtn.Name = "regresarBtn";
            this.regresarBtn.Size = new System.Drawing.Size(126, 55);
            this.regresarBtn.TabIndex = 5;
            this.regresarBtn.Text = "Inicio";
            this.regresarBtn.UseVisualStyleBackColor = true;
            this.regresarBtn.Click += new System.EventHandler(this.regresarBtn_Click);
            // 
            // salirbtn
            // 
            this.salirbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salirbtn.BackgroundImage")));
            this.salirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salirbtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salirbtn.Location = new System.Drawing.Point(903, 498);
            this.salirbtn.Name = "salirbtn";
            this.salirbtn.Size = new System.Drawing.Size(126, 55);
            this.salirbtn.TabIndex = 6;
            this.salirbtn.Text = "Salir";
            this.salirbtn.UseVisualStyleBackColor = true;
            this.salirbtn.Click += new System.EventHandler(this.salirbtn_Click);
            // 
            // pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1112, 644);
            this.Controls.Add(this.salirbtn);
            this.Controls.Add(this.regresarBtn);
            this.Controls.Add(this.verEstadoBtn);
            this.Controls.Add(this.EstadoBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pagos";
            this.Text = "pagos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EstadoBtn;
        private System.Windows.Forms.Button verEstadoBtn;
        private System.Windows.Forms.Button regresarBtn;
        private System.Windows.Forms.Button salirbtn;
    }
}