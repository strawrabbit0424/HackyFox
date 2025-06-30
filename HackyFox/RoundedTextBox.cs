using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackyFox
{
    //Morales Mendez 30/06/2025
    //objeto para un bloque de texto visual
    //con fondo amarillo pastel y esquinas redondeadas
    public class RoundedTextBox : UserControl
    {
        private TextBox textBox = new TextBox(); //herramienta base

        // Radio de las esquinas redondeadas
        private int borderRadius = 20;

        // Constructor del control personalizado
        public RoundedTextBox()
        {
            // Tamaño y fondo del control
            this.Size = new Size(300, 120);
            this.BackColor = Color.FromArgb(247, 242, 172); // fondo pastel amarillo

            // Configuración del TextBox interno
            textBox.Multiline = true;                  // permite varias líneas
            textBox.ReadOnly = true;                   // solo lectura (no editable)
            textBox.BorderStyle = BorderStyle.None;   // sin borde propio
            textBox.BackColor = this.BackColor;       // mismo color que el fondo del control
            textBox.ForeColor = Color.FromArgb(1, 149, 177); // color del texto HackyFox (turquesa)
            textBox.Dock = DockStyle.Fill;             // ocupa todo el espacio del control
            textBox.Cursor = Cursors.Default;          // cursor normal
            textBox.TabStop = false;                    // no enfocable con Tab

            // espacio dentro el bloque para el texto (sangria/padding)
            textBox.Location = new Point(10, 10);
            textBox.Size = new Size(this.Width - 20, this.Height - 20);
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            //TextBox al control
            this.Controls.Add(textBox);
        }

        // Se encarga de dibujar el control con esquinas redondeadas
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Habilitar suavizado para bordes redondeados
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear región con esquinas redondeadas y aplicarla al control
            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
            {
                this.Region = new Region(path);
            }
        }

        // Crea una ruta de esquinas redondeadas para definir la forma visible del control
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);                  // esquina superior izquierda
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);  // esquina superior derecha
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // esquina inferior derecha
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);   // esquina inferior izquierda
            path.CloseFigure(); // cerrar la figura

            return path;
        }

        // Propiedad pública para cambiar o leer el texto mostrado en el control
        [Category("Contenido")]
        public string Texts
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        // Sobrescribe la propiedad Text para que se comporte como un TextBox normal
        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }
    }
}

