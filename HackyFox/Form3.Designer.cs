namespace HackyFox
{
    partial class Menu
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
            panelSlideMenu = new Panel();
            button2 = new Button();
            btnLeccion = new Button();
            btnUser = new Button();
            panelLogo = new Panel();
            panelSlideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelSlideMenu
            // 
            panelSlideMenu.AutoScroll = true;
            panelSlideMenu.BackColor = Color.FromArgb(155, 209, 219);
            panelSlideMenu.Controls.Add(button2);
            panelSlideMenu.Controls.Add(btnLeccion);
            panelSlideMenu.Controls.Add(btnUser);
            panelSlideMenu.Controls.Add(panelLogo);
            panelSlideMenu.Dock = DockStyle.Left;
            panelSlideMenu.Font = new Font("Clear Sans", 9F);
            panelSlideMenu.Location = new Point(0, 0);
            panelSlideMenu.Name = "panelSlideMenu";
            panelSlideMenu.Size = new Size(300, 553);
            panelSlideMenu.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 241, 62);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Clear Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(5, 122, 144);
            button2.Location = new Point(0, 223);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(300, 68);
            button2.TabIndex = 3;
            button2.Text = "Mascota";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnLeccion
            // 
            btnLeccion.Dock = DockStyle.Top;
            btnLeccion.FlatAppearance.BorderSize = 0;
            btnLeccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 241, 62);
            btnLeccion.FlatStyle = FlatStyle.Flat;
            btnLeccion.Font = new Font("Clear Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeccion.ForeColor = Color.FromArgb(5, 122, 144);
            btnLeccion.Location = new Point(0, 155);
            btnLeccion.Name = "btnLeccion";
            btnLeccion.Padding = new Padding(10, 0, 0, 0);
            btnLeccion.Size = new Size(300, 68);
            btnLeccion.TabIndex = 2;
            btnLeccion.Text = "Lecciones";
            btnLeccion.TextAlign = ContentAlignment.MiddleLeft;
            btnLeccion.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 241, 62);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Clear Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.FromArgb(5, 122, 144);
            btnUser.Location = new Point(0, 87);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(10, 0, 0, 0);
            btnUser.Size = new Size(300, 68);
            btnUser.TabIndex = 1;
            btnUser.Text = "Usuario";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(300, 87);
            panelLogo.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(panelSlideMenu);
            MaximumSize = new Size(950, 600);
            Name = "Menu";
            Text = "Menú - HackyFox";
            panelSlideMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSlideMenu;
        private Button btnUser;
        private Panel panelLogo;
        private Button button2;
        private Button btnLeccion;
    }
}