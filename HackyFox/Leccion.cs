using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
