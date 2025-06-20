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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panelmenu = new Panel();
            pictureBox1 = new PictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 25F);
            label2.Location = new Point(267, 19);
            label2.Name = "label2";
            label2.Size = new Size(184, 53);
            label2.TabIndex = 2;
            label2.Text = "Leccion 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comfortaa", 20F);
            label3.Location = new Point(330, 72);
            label3.Name = "label3";
            label3.Size = new Size(363, 42);
            label3.TabIndex = 3;
            label3.Text = "Conceptos ciberseguros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("04b_19", 30F);
            label1.ForeColor = Color.FromArgb(0, 151, 178);
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(201, 40);
            label1.TabIndex = 0;
            label1.Text = "HackyFox";
            // 
            // panelmenu
            // 
            panelmenu.BackColor = Color.FromArgb(210, 232, 236);
            panelmenu.Controls.Add(label6);
            panelmenu.Controls.Add(label5);
            panelmenu.Controls.Add(label4);
            panelmenu.Controls.Add(pictureBox1);
            panelmenu.Controls.Add(iconPictureBox3);
            panelmenu.Controls.Add(iconPictureBox2);
            panelmenu.Controls.Add(iconPictureBox1);
            panelmenu.Controls.Add(label1);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(261, 504);
            panelmenu.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.peticon;
            pictureBox1.Location = new Point(3, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(210, 232, 236);
            iconPictureBox3.ForeColor = Color.FromArgb(0, 142, 166);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconPictureBox3.IconColor = Color.FromArgb(0, 142, 166);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 64;
            iconPictureBox3.Location = new Point(3, 198);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(82, 64);
            iconPictureBox3.TabIndex = 6;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(210, 232, 236);
            iconPictureBox2.ForeColor = Color.FromArgb(0, 142, 166);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconPictureBox2.IconColor = Color.FromArgb(0, 142, 166);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 64;
            iconPictureBox2.Location = new Point(3, 110);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(82, 64);
            iconPictureBox2.TabIndex = 5;
            iconPictureBox2.TabStop = false;
            iconPictureBox2.Click += iconPictureBox2_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(210, 232, 236);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comfortaa", 20F);
            label4.Location = new Point(61, 120);
            label4.Name = "label4";
            label4.Size = new Size(131, 42);
            label4.TabIndex = 5;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comfortaa", 20F);
            label5.Location = new Point(61, 208);
            label5.Name = "label5";
            label5.Size = new Size(159, 42);
            label5.TabIndex = 7;
            label5.Text = "Lecciones";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comfortaa", 20F);
            label6.Location = new Point(61, 288);
            label6.Name = "label6";
            label6.Size = new Size(141, 42);
            label6.TabIndex = 8;
            label6.Text = "Mascota";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 504);
            Controls.Add(panelmenu);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Microsoft Sans Serif", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "HackyFox- Lecciones";
            panelmenu.ResumeLayout(false);
            panelmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panelmenu;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}
