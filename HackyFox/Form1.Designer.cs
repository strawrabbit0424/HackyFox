namespace HackyFox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.Location = new Point(90, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(917, 559);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Copia_de_HackyFox__2_;
            pictureBox1.Location = new Point(205, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(693, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(174, 225, 235);
            button1.Font = new Font("Comfortaa", 16F);
            button1.Location = new Point(443, 376);
            button1.Name = "button1";
            button1.Size = new Size(205, 68);
            button1.TabIndex = 3;
            button1.Text = "Inciar sesión";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Clear Sans", 25F, FontStyle.Bold);
            label1.Location = new Point(408, 298);
            label1.Name = "label1";
            label1.Size = new Size(264, 58);
            label1.TabIndex = 4;
            label1.Text = "¡Bienvenido!";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(174, 225, 235);
            button2.Font = new Font("Comfortaa", 18F);
            button2.Location = new Point(443, 463);
            button2.Name = "button2";
            button2.Size = new Size(205, 62);
            button2.TabIndex = 5;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 62);
            ClientSize = new Size(1108, 726);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Font = new Font("Microsoft Sans Serif", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "Form1";
            Text = "HackyFox- Lecciones";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}

