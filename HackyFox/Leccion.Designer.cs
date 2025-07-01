namespace HackyFox
{
    partial class Leccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leccion));
            panel1 = new Panel();
            panel2 = new Panel();
            LbTituloL = new Label();
            panel3 = new Panel();
            TbConsejo = new TextBox();
            pictureBox1 = new PictureBox();
            TbContenidoL = new RoundedTextBox();
            LbSubtituloL = new Label();
            LbTituloContenidoL = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(67, 734);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(155, 209, 219);
            panel2.Controls.Add(LbTituloL);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(67, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 48);
            panel2.TabIndex = 1;
            // 
            // LbTituloL
            // 
            LbTituloL.AutoSize = true;
            LbTituloL.Font = new Font("Clear Sans", 23F);
            LbTituloL.ForeColor = SystemColors.ControlLightLight;
            LbTituloL.Location = new Point(6, 5);
            LbTituloL.Name = "LbTituloL";
            LbTituloL.Size = new Size(105, 43);
            LbTituloL.TabIndex = 0;
            LbTituloL.Text = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 241, 62);
            panel3.Controls.Add(TbConsejo);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(TbContenidoL);
            panel3.Controls.Add(LbSubtituloL);
            panel3.Controls.Add(LbTituloContenidoL);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(67, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(1043, 686);
            panel3.TabIndex = 2;
            // 
            // TbConsejo
            // 
            TbConsejo.BackColor = Color.FromArgb(251, 246, 184);
            TbConsejo.BorderStyle = BorderStyle.None;
            TbConsejo.Font = new Font("Comfortaa", 18F);
            TbConsejo.ForeColor = Color.FromArgb(1, 149, 177);
            TbConsejo.Location = new Point(746, 75);
            TbConsejo.Multiline = true;
            TbConsejo.Name = "TbConsejo";
            TbConsejo.Size = new Size(245, 113);
            TbConsejo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.consejopic;
            pictureBox1.Location = new Point(587, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // TbContenidoL
            // 
            TbContenidoL.BackColor = Color.FromArgb(247, 242, 172);
            TbContenidoL.Font = new Font("Segoe UI", 20F);
            TbContenidoL.Location = new Point(29, 276);
            TbContenidoL.Name = "TbContenidoL";
            TbContenidoL.Size = new Size(523, 371);
            TbContenidoL.TabIndex = 2;
            TbContenidoL.Texts = "";
            // 
            // LbSubtituloL
            // 
            LbSubtituloL.AutoSize = true;
            LbSubtituloL.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbSubtituloL.ForeColor = Color.FromArgb(5, 122, 144);
            LbSubtituloL.Location = new Point(64, 136);
            LbSubtituloL.Name = "LbSubtituloL";
            LbSubtituloL.Size = new Size(98, 42);
            LbSubtituloL.TabIndex = 1;
            LbSubtituloL.Text = "label1";
            LbSubtituloL.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbTituloContenidoL
            // 
            LbTituloContenidoL.AutoSize = true;
            LbTituloContenidoL.Font = new Font("Comfortaa", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTituloContenidoL.ForeColor = Color.FromArgb(5, 122, 144);
            LbTituloContenidoL.Location = new Point(42, 39);
            LbTituloContenidoL.Name = "LbTituloContenidoL";
            LbTituloContenidoL.Size = new Size(146, 62);
            LbTituloContenidoL.TabIndex = 0;
            LbTituloContenidoL.Text = "label1";
            LbTituloContenidoL.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Leccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 734);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "Leccion";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label LbTituloL;
        private Label LbTituloContenidoL;
        private Label LbSubtituloL;
        private RoundedTextBox TbContenidoL;
        private PictureBox pictureBox1;
        private TextBox TbConsejo;
    }
}