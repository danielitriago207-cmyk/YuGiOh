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
    public partial class Form1 : Form
    {
        Carta cartaSeleccionada1 = null;
        Carta cartaSeleccionada2 = null;
        public Form1()
        {
            InitializeComponent();
        }
            private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

            // Ruta del archivo de video
            string rutaVideo = @"C:\Users\isaac\Downloads\konami.mp4";

            // Configurar el reproductor
            axWindowsMediaPlayer1.URL = rutaVideo;  // Esto carga y reproduce automáticamente el video
            axWindowsMediaPlayer1.Ctlcontrols.play(); // Inicia la reproducción
            axWindowsMediaPlayer1.uiMode = "none";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCartas F2 = new FormCartas();
            F2.Show();
            this.Hide();
        }
    }
    
    
}
