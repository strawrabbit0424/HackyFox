using HackyFox.Properties;

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
            pictureBox1Menu = new PictureBox();
            welcomeLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panelmenu = new Panel();
            label5 = new Label();
            label4 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_personalizado1 = new Btn_personalizado();
            btn_personalizado2 = new Btn_personalizado();
            btn_personalizado3 = new Btn_personalizado();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Menu).BeginInit();
            panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1Menu
            // 
            pictureBox1Menu.BackColor = Color.Transparent;
            pictureBox1Menu.Location = new Point(0, 317);
            pictureBox1Menu.Name = "pictureBox1Menu";
            pictureBox1Menu.Size = new Size(62, 68);
            pictureBox1Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1Menu.TabIndex = 5;
            pictureBox1Menu.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.White;
            welcomeLabel.Font = new Font("Clear Sans", 25F, FontStyle.Bold);
            welcomeLabel.Location = new Point(421, 315);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(264, 58);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "¡Bienvenido!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F);
            label2.Location = new Point(267, 19);
            label2.Name = "label2";
            label2.Size = new Size(163, 39);
            label2.TabIndex = 2;
            label2.Text = "Leccion 1";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 8;
            // 
            // panelmenu
            // 
            panelmenu.BackColor = Color.FromArgb(155, 209, 219);
            panelmenu.Controls.Add(pictureBox1Menu);
            panelmenu.Controls.Add(label5);
            panelmenu.Controls.Add(label4);
            panelmenu.Controls.Add(iconPictureBox3);
            panelmenu.Controls.Add(iconPictureBox2);
            panelmenu.Controls.Add(iconPictureBox1);
            panelmenu.Controls.Add(label1);
            panelmenu.Controls.Add(label6);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(261, 504);
            panelmenu.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comfortaa", 20F);
            label5.Location = new Point(74, 227);
            label5.Name = "label5";
            label5.Size = new Size(200, 53);
            label5.TabIndex = 7;
            label5.Text = "Lecciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comfortaa", 20F);
            label4.Location = new Point(73, 120);
            label4.Name = "label4";
            label4.Size = new Size(164, 53);
            label4.TabIndex = 5;
            label4.Text = "Usuario";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(155, 209, 219);
            iconPictureBox3.ForeColor = Color.FromArgb(0, 142, 166);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconPictureBox3.IconColor = Color.FromArgb(0, 142, 166);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 73;
            iconPictureBox3.Location = new Point(0, 217);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(82, 73);
            iconPictureBox3.TabIndex = 6;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(155, 209, 219);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 73;
            iconPictureBox2.Location = new Point(0, 110);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(82, 73);
            iconPictureBox2.TabIndex = 5;
            iconPictureBox2.TabStop = false;
            iconPictureBox2.Click += iconPictureBox2_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(155, 209, 219);
            iconPictureBox1.ForeColor = Color.FromArgb(0, 142, 166);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bars;
            iconPictureBox1.IconColor = Color.FromArgb(0, 142, 166);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 56;
            iconPictureBox1.Location = new Point(202, 19);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(56, 58);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Comfortaa", 20F);
            label6.Location = new Point(74, 331);
            label6.Name = "label6";
            label6.Size = new Size(177, 53);
            label6.TabIndex = 8;
            label6.Text = "Mascota";
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
            pictureBox1.Image = Resources.textox;
            pictureBox1.Location = new Point(276, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btn_personalizado1
            // 
            btn_personalizado1.BackColor = Color.FromArgb(247, 242, 172);
            btn_personalizado1.FlatStyle = FlatStyle.Flat;
            btn_personalizado1.ForeColor = Color.FromArgb(1, 149, 177);
            btn_personalizado1.Location = new Point(0, 0);
            btn_personalizado1.Name = "btn_personalizado1";
            btn_personalizado1.Size = new Size(150, 40);
            btn_personalizado1.TabIndex = 0;
            btn_personalizado1.UseVisualStyleBackColor = false;
            // 
            // btn_personalizado2
            // 
            btn_personalizado2.BackColor = Color.FromArgb(174, 225, 235);
            btn_personalizado2.FlatAppearance.BorderSize = 0;
            btn_personalizado2.FlatStyle = FlatStyle.Flat;
            btn_personalizado2.Font = new Font("Comfortaa", 10F, FontStyle.Bold);
            btn_personalizado2.ForeColor = Color.Black;
            btn_personalizado2.Location = new Point(431, 394);
            btn_personalizado2.Name = "btn_personalizado2";
            btn_personalizado2.Size = new Size(239, 69);
            btn_personalizado2.TabIndex = 7;
            btn_personalizado2.Text = "Iniciar sesión";
            btn_personalizado2.UseVisualStyleBackColor = false;
            btn_personalizado2.Click += btn_personalizado2_Click;
            // 
            // btn_personalizado3
            // 
            btn_personalizado3.BackColor = Color.FromArgb(174, 225, 235);
            btn_personalizado3.FlatAppearance.BorderSize = 0;
            btn_personalizado3.FlatStyle = FlatStyle.Flat;
            btn_personalizado3.Font = new Font("Comfortaa", 10F, FontStyle.Bold);
            btn_personalizado3.ForeColor = Color.Black;
            btn_personalizado3.Location = new Point(431, 493);
            btn_personalizado3.Name = "btn_personalizado3";
            btn_personalizado3.Size = new Size(239, 69);
            btn_personalizado3.TabIndex = 8;
            btn_personalizado3.Text = "Registrarse";
            btn_personalizado3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 62);
            ClientSize = new Size(1108, 726);
            Controls.Add(btn_personalizado3);
            Controls.Add(btn_personalizado2);
            Controls.Add(pictureBox1);
            Controls.Add(welcomeLabel);
            Controls.Add(pictureBox2);
            Font = new Font("Microsoft Sans Serif", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "Form1";
            Text = "HackyFox- Lecciones";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1Menu).EndInit();
            panelmenu.ResumeLayout(false);
            panelmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1Menu;
        private Label welcomeLabel; // Renamed from 'label1'

        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panelmenu;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label5;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Btn_personalizado btn_personalizado1;
        private Btn_personalizado btn_personalizado2;
        private Btn_personalizado btn_personalizado3;
    }
}
