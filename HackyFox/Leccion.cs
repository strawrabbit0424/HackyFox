using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackyFox
{
    public partial class Leccion : Form
    {
        public Leccion()
        {
            InitializeComponent();

            //informacion de labels
            LbTituloL.Text = "Leccion 1. Escudo seguro";
            LbTituloContenidoL.Text = "¿Que es la ciberseguridad?";
            LbSubtituloL.Text = "¡Es cuidar tu información cuando usas internet!";

            // "\r\n\r\n" representa dos saltos de línea en Windows,
            // es decir, una línea en blanco entre párrafos para separar el texto visualmente.
            TbContenidoL.Text = "Nos ayuda a estar seguros en internet. \r\n\r\nUsamos contraseñas difíciles, no damos nuestra información a extraños y evitamos mensajes raros.\r\n \r\nAsí usamos la tecnología sin riesgos y cuidamos cómo nos mostramos en el mundo digital.";
            TbConsejo.Text = "¡Aprendamos a estar seguros en internet!";
        }







        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
