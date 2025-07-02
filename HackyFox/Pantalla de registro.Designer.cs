namespace HackyFox
{
    partial class PantallaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistro));
            pbRegistro = new PictureBox();
            lbNacimientoRegistro = new Label();
            lbAlias = new Label();
            lbAliasAdvertencia = new Label();
            btnAlias = new Btn_personalizado();
            tbFechaNacimiento = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbRegistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbRegistro
            // 
            pbRegistro.BackColor = Color.Transparent;
            pbRegistro.Image = (Image)resources.GetObject("pbRegistro.Image");
            pbRegistro.Location = new Point(283, 34);
            pbRegistro.Name = "pbRegistro";
            pbRegistro.Size = new Size(522, 128);
            pbRegistro.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRegistro.TabIndex = 7;
            pbRegistro.TabStop = false;
            // 
            // lbNacimientoRegistro
            // 
            lbNacimientoRegistro.AutoSize = true;
            lbNacimientoRegistro.BackColor = Color.FromArgb(242, 242, 242);
            lbNacimientoRegistro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lbNacimientoRegistro.ForeColor = Color.FromArgb(0, 151, 178);
            lbNacimientoRegistro.Location = new Point(427, 258);
            lbNacimientoRegistro.Name = "lbNacimientoRegistro";
            lbNacimientoRegistro.Size = new Size(249, 31);
            lbNacimientoRegistro.TabIndex = 9;
            lbNacimientoRegistro.Text = "¿Cuándo naciste?";
            lbNacimientoRegistro.Click += label1_Click_1;
            // 
            // lbAlias
            // 
            lbAlias.AutoSize = true;
            lbAlias.BackColor = Color.FromArgb(242, 242, 242);
            lbAlias.Font = new Font("Comfortaa", 13F, FontStyle.Bold);
            lbAlias.ForeColor = Color.FromArgb(0, 151, 178);
            lbAlias.Location = new Point(356, 399);
            lbAlias.Name = "lbAlias";
            lbAlias.Size = new Size(400, 34);
            lbAlias.TabIndex = 11;
            lbAlias.Text = "¡Elige un alias a tu compañero!";
            // 
            // lbAliasAdvertencia
            // 
            lbAliasAdvertencia.AutoSize = true;
            lbAliasAdvertencia.BackColor = Color.FromArgb(242, 242, 242);
            lbAliasAdvertencia.Font = new Font("Comfortaa", 9F, FontStyle.Bold | FontStyle.Italic);
            lbAliasAdvertencia.ForeColor = Color.FromArgb(97, 54, 37);
            lbAliasAdvertencia.Location = new Point(438, 454);
            lbAliasAdvertencia.Name = "lbAliasAdvertencia";
            lbAliasAdvertencia.Size = new Size(220, 23);
            lbAliasAdvertencia.TabIndex = 13;
            lbAliasAdvertencia.Text = "(No uses tu nombre real)";
            // 
            // btnAlias
            // 
            btnAlias.BackColor = Color.FromArgb(174, 225, 235);
            btnAlias.FlatAppearance.BorderSize = 0;
            btnAlias.FlatStyle = FlatStyle.Flat;
            btnAlias.Font = new Font("Comfortaa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlias.ForeColor = Color.FromArgb(97, 54, 37);
            btnAlias.Location = new Point(445, 606);
            btnAlias.Name = "btnAlias";
            btnAlias.Size = new Size(213, 95);
            btnAlias.TabIndex = 14;
            btnAlias.Text = "¡Me gusta ese nombre!";
            btnAlias.UseVisualStyleBackColor = false;
            // 
            // tbFechaNacimiento
            // 
            tbFechaNacimiento.BackColor = Color.FromArgb(196, 211, 217);
            tbFechaNacimiento.ForeColor = Color.FromArgb(141, 65, 38);
            tbFechaNacimiento.Location = new Point(393, 318);
            tbFechaNacimiento.Multiline = true;
            tbFechaNacimiento.Name = "tbFechaNacimiento";
            tbFechaNacimiento.Size = new Size(314, 40);
            tbFechaNacimiento.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(196, 211, 217);
            textBox1.ForeColor = Color.FromArgb(141, 65, 38);
            textBox1.Location = new Point(393, 517);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 40);
            textBox1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(769, 622);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // PantallaRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 62);
            ClientSize = new Size(1108, 763);
            Controls.Add(textBox1);
            Controls.Add(tbFechaNacimiento);
            Controls.Add(btnAlias);
            Controls.Add(lbAliasAdvertencia);
            Controls.Add(lbAlias);
            Controls.Add(lbNacimientoRegistro);
            Controls.Add(pbRegistro);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "PantallaRegistro";
            Text = "HackyFox-Registro";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pbRegistro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbRegistro;
        private Label lbNacimientoRegistro;
        private Label lbAlias;
        private Label lbAliasAdvertencia;
        private Btn_personalizado btnAlias;
        private TextBox tbFechaNacimiento;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}