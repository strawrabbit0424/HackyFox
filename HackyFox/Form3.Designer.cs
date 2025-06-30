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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panelMenu = new Panel();
            btnMascota = new FontAwesome.Sharp.IconButton();
            btnLecciones = new FontAwesome.Sharp.IconButton();
            btnUser = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            pbLogo = new PictureBox();
            panelTitleBar = new Panel();
            lbLecciones = new Label();
            panelDesk = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(155, 209, 219);
            panelMenu.Controls.Add(btnMascota);
            panelMenu.Controls.Add(btnLecciones);
            panelMenu.Controls.Add(btnUser);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Font = new Font("Clear Sans", 9F);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 726);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnMascota
            // 
            btnMascota.BackgroundImageLayout = ImageLayout.Stretch;
            btnMascota.Dock = DockStyle.Top;
            btnMascota.FlatAppearance.BorderSize = 0;
            btnMascota.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 222, 89);
            btnMascota.FlatStyle = FlatStyle.Flat;
            btnMascota.Font = new Font("Clear Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMascota.ForeColor = Color.FromArgb(5, 122, 144);
            btnMascota.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            btnMascota.IconColor = Color.FromArgb(5, 122, 144);
            btnMascota.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMascota.IconSize = 30;
            btnMascota.ImageAlign = ContentAlignment.MiddleLeft;
            btnMascota.Location = new Point(0, 227);
            btnMascota.Name = "btnMascota";
            btnMascota.Padding = new Padding(10, 0, 0, 0);
            btnMascota.RightToLeft = RightToLeft.No;
            btnMascota.Size = new Size(230, 67);
            btnMascota.TabIndex = 5;
            btnMascota.Tag = "Mascota";
            btnMascota.Text = "Mascota";
            btnMascota.TextAlign = ContentAlignment.MiddleLeft;
            btnMascota.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMascota.UseMnemonic = false;
            btnMascota.UseVisualStyleBackColor = true;
            // 
            // btnLecciones
            // 
            btnLecciones.BackgroundImageLayout = ImageLayout.Stretch;
            btnLecciones.Dock = DockStyle.Top;
            btnLecciones.FlatAppearance.BorderSize = 0;
            btnLecciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 222, 89);
            btnLecciones.FlatStyle = FlatStyle.Flat;
            btnLecciones.Font = new Font("Clear Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLecciones.ForeColor = Color.FromArgb(5, 122, 144);
            btnLecciones.IconChar = FontAwesome.Sharp.IconChar.Tape;
            btnLecciones.IconColor = Color.FromArgb(5, 122, 144);
            btnLecciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLecciones.IconSize = 30;
            btnLecciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnLecciones.Location = new Point(0, 160);
            btnLecciones.Name = "btnLecciones";
            btnLecciones.Padding = new Padding(10, 0, 0, 0);
            btnLecciones.RightToLeft = RightToLeft.No;
            btnLecciones.Size = new Size(230, 67);
            btnLecciones.TabIndex = 4;
            btnLecciones.Tag = "Lecciones";
            btnLecciones.Text = "Lecciones";
            btnLecciones.TextAlign = ContentAlignment.MiddleLeft;
            btnLecciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLecciones.UseMnemonic = false;
            btnLecciones.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 222, 89);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Clear Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.FromArgb(5, 122, 144);
            btnUser.IconChar = FontAwesome.Sharp.IconChar.User;
            btnUser.IconColor = Color.FromArgb(5, 122, 144);
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUser.IconSize = 30;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 93);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(10, 0, 0, 0);
            btnUser.RightToLeft = RightToLeft.No;
            btnUser.Size = new Size(230, 67);
            btnUser.TabIndex = 3;
            btnUser.Tag = "Usuario";
            btnUser.Text = "Usuario";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseMnemonic = false;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click_1;
            // 
            // btnExit
            // 
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 222, 89);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Clear Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(5, 122, 144);
            btnExit.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            btnExit.IconColor = Color.FromArgb(5, 122, 144);
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 25;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 659);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(230, 67);
            btnExit.TabIndex = 2;
            btnExit.Tag = "Salir";
            btnExit.Text = "Salir";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Controls.Add(btnMenu);
            panelLogo.Controls.Add(pbLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(230, 93);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // btnMenu
            // 
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 222, 89);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.FromArgb(5, 122, 144);
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 30;
            btnMenu.Location = new Point(186, 9);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(38, 63);
            btnMenu.TabIndex = 1;
            btnMenu.Tag = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(3, 22);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(177, 40);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.White;
            panelTitleBar.Controls.Add(lbLecciones);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(230, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(878, 72);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panel1_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // lbLecciones
            // 
            lbLecciones.AutoSize = true;
            lbLecciones.Font = new Font("Comfortaa", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLecciones.ForeColor = Color.FromArgb(64, 0, 0);
            lbLecciones.Location = new Point(6, 9);
            lbLecciones.Name = "lbLecciones";
            lbLecciones.Size = new Size(200, 53);
            lbLecciones.TabIndex = 0;
            lbLecciones.Text = "Lecciones";
            lbLecciones.Click += lbLecciones_Click;
            // 
            // panelDesk
            // 
            panelDesk.BackColor = Color.FromArgb(242, 242, 242);
            panelDesk.Dock = DockStyle.Fill;
            panelDesk.Location = new Point(230, 72);
            panelDesk.Name = "panelDesk";
            panelDesk.Size = new Size(878, 654);
            panelDesk.TabIndex = 2;
            panelDesk.Paint += panelDesk_Paint;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 726);
            Controls.Add(panelDesk);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(950, 600);
            Name = "Menu";
            Text = "Menú - HackyFox";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Panel panelDesk;
        private FontAwesome.Sharp.IconButton btnMenu;
        private PictureBox pbLogo;
        private Label lbLecciones;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnMascota;
        private FontAwesome.Sharp.IconButton btnLecciones;
    }
}