namespace HackyFox
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            pbRegistro = new PictureBox();
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(170, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(766, 575);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 62);
            ClientSize = new Size(1108, 726);
            Controls.Add(pictureBox1);
            Controls.Add(pbRegistro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "Registro";
            Text = "HackyFox-Registro";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pbRegistro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbRegistro;
        private PictureBox pictureBox1;
    }
}