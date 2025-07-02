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
            panelL1 = new Panel();
            lbTitleL1 = new Label();
            lbTemaL1 = new Label();
            btnInfoL1 = new Button();
            btnRetoL1 = new Button();
            btnDinamicaL1 = new Button();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panelTitleBar.SuspendLayout();
            panelDesk.SuspendLayout();
            panelL1.SuspendLayout();
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
            panelDesk.Controls.Add(panelL1);
            panelDesk.Dock = DockStyle.Fill;
            panelDesk.Location = new Point(230, 72);
            panelDesk.Name = "panelDesk";
            panelDesk.Size = new Size(878, 654);
            panelDesk.TabIndex = 2;
            panelDesk.Paint += panelDesk_Paint;
            // 
            // panelL1
            // 
            panelL1.Controls.Add(btnDinamicaL1);
            panelL1.Controls.Add(btnRetoL1);
            panelL1.Controls.Add(btnInfoL1);
            panelL1.Controls.Add(lbTemaL1);
            panelL1.Controls.Add(lbTitleL1);
            panelL1.Location = new Point(87, 57);
            panelL1.Name = "panelL1";
            panelL1.Size = new Size(722, 451);
            panelL1.TabIndex = 0;
            // 
            // lbTitleL1
            // 
            lbTitleL1.AutoSize = true;
            lbTitleL1.FlatStyle = FlatStyle.Flat;
            lbTitleL1.Font = new Font("Clear Sans", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitleL1.ForeColor = Color.FromArgb(0, 74, 173);
            lbTitleL1.Location = new Point(11, 22);
            lbTitleL1.Name = "lbTitleL1";
            lbTitleL1.Size = new Size(234, 66);
            lbTitleL1.TabIndex = 0;
            lbTitleL1.Text = "Lección 1";
            // 
            // lbTemaL1
            // 
            lbTemaL1.AutoSize = true;
            lbTemaL1.FlatStyle = FlatStyle.Flat;
            lbTemaL1.Font = new Font("Clear Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTemaL1.ForeColor = Color.FromArgb(0, 151, 178);
            lbTemaL1.Location = new Point(49, 79);
            lbTemaL1.Name = "lbTemaL1";
            lbTemaL1.Size = new Size(254, 47);
            lbTemaL1.TabIndex = 1;
            lbTemaL1.Text = "Escudo Seguro";
            // 
            // btnInfoL1
            // 
            btnInfoL1.FlatAppearance.BorderSize = 0;
            btnInfoL1.FlatStyle = FlatStyle.Flat;
            btnInfoL1.Font = new Font("Comfortaa", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfoL1.ForeColor = Color.FromArgb(0, 74, 173);
            btnInfoL1.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfoL1.Location = new Point(0, 159);
            btnInfoL1.Name = "btnInfoL1";
            btnInfoL1.Padding = new Padding(10, 0, 0, 0);
            btnInfoL1.Size = new Size(722, 78);
            btnInfoL1.TabIndex = 2;
            btnInfoL1.Text = "¿Qué es la ciberseguridad?";
            btnInfoL1.TextAlign = ContentAlignment.MiddleLeft;
            btnInfoL1.UseVisualStyleBackColor = true;
            btnInfoL1.Click += btnInfoL1_Click;
            // 
            // btnRetoL1
            // 
            btnRetoL1.FlatAppearance.BorderSize = 0;
            btnRetoL1.FlatStyle = FlatStyle.Flat;
            btnRetoL1.Font = new Font("Comfortaa", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetoL1.ForeColor = Color.FromArgb(0, 74, 173);
            btnRetoL1.ImageAlign = ContentAlignment.MiddleLeft;
            btnRetoL1.Location = new Point(0, 234);
            btnRetoL1.Name = "btnRetoL1";
            btnRetoL1.Padding = new Padding(10, 0, 0, 0);
            btnRetoL1.Size = new Size(722, 78);
            btnRetoL1.TabIndex = 3;
            btnRetoL1.Text = "¡Reto Relampago!";
            btnRetoL1.TextAlign = ContentAlignment.MiddleLeft;
            btnRetoL1.UseVisualStyleBackColor = true;
            btnRetoL1.Click += btnRetoL1_Click;
            // 
            // btnDinamicaL1
            // 
            btnDinamicaL1.FlatAppearance.BorderSize = 0;
            btnDinamicaL1.FlatStyle = FlatStyle.Flat;
            btnDinamicaL1.Font = new Font("Comfortaa", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDinamicaL1.ForeColor = Color.FromArgb(0, 74, 173);
            btnDinamicaL1.ImageAlign = ContentAlignment.MiddleLeft;
            btnDinamicaL1.Location = new Point(0, 305);
            btnDinamicaL1.Name = "btnDinamicaL1";
            btnDinamicaL1.Padding = new Padding(10, 0, 0, 0);
            btnDinamicaL1.Size = new Size(722, 78);
            btnDinamicaL1.TabIndex = 4;
            btnDinamicaL1.Text = "¡Cuidado!";
            btnDinamicaL1.TextAlign = ContentAlignment.MiddleLeft;
            btnDinamicaL1.UseVisualStyleBackColor = true;
            btnDinamicaL1.Click += btnDinamicaL1_Click;
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
            panelDesk.ResumeLayout(false);
            panelL1.ResumeLayout(false);
            panelL1.PerformLayout();
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
        private Panel panelL1;
        private Label lbTemaL1;
        private Label lbTitleL1;
        private Button btnRetoL1;
        private Button btnInfoL1;
        private Button btnDinamicaL1;
    }
}