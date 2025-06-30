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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            LbTituloL = new Label();
            LbTituloContenidoL = new Label();
            LbSubtituloL = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            // panel3
            // 
            panel3.Controls.Add(LbSubtituloL);
            panel3.Controls.Add(LbTituloContenidoL);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(67, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(1043, 686);
            panel3.TabIndex = 2;
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
            // LbTituloContenidoL
            // 
            LbTituloContenidoL.AutoSize = true;
            LbTituloContenidoL.Font = new Font("Comfortaa", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTituloContenidoL.ForeColor = Color.FromArgb(5, 122, 144);
            LbTituloContenidoL.Location = new Point(37, 35);
            LbTituloContenidoL.Name = "LbTituloContenidoL";
            LbTituloContenidoL.Size = new Size(146, 62);
            LbTituloContenidoL.TabIndex = 0;
            LbTituloContenidoL.Text = "label1";
            LbTituloContenidoL.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LbSubtituloL
            // 
            LbSubtituloL.AutoSize = true;
            LbSubtituloL.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbSubtituloL.ForeColor = Color.FromArgb(5, 122, 144);
            LbSubtituloL.Location = new Point(243, 116);
            LbSubtituloL.Name = "LbSubtituloL";
            LbSubtituloL.Size = new Size(98, 42);
            LbSubtituloL.TabIndex = 1;
            LbSubtituloL.Text = "label1";
            LbSubtituloL.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Leccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 734);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(950, 600);
            Name = "Leccion";
            Text = "Leccion";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label LbTituloL;
        private Label LbTituloContenidoL;
        private Label LbSubtituloL;
    }
}