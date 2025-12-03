using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuGiOh
{
    public partial class FormCartas : Form
    {
        int cartasSeleccionadas = 0;
        public FormCartas()
        {
            InitializeComponent();
        }
        private void verificarSeleccion()
        {
            if (cartasSeleccionadas == 2)
            {
                // Ir al otro formulario
                FormCartas f2 = new FormCartas();
                f2.Show();

                this.Hide(); // Oculta el formulario actual
            }
        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Esta es la información de la imagen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Marcar la carta como seleccionada visualmente (opcional)
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;

            cartasSeleccionadas++;

            verificarSeleccion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Marcar la carta como seleccionada visualmente (opcional)
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;

            cartasSeleccionadas++;

            verificarSeleccion();
        }
    }
}
