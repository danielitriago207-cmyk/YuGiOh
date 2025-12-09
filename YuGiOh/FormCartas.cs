using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YuGiOh
{
    public partial class FormCartas : Form
    {
        private List<Carta> mazo = new List<Carta>();
        private Carta cartaJugador = null;

        public FormCartas()
        {
            InitializeComponent();
            InicializarMazo();
            ConfigurarEventosCartas();
        }

        private void InicializarMazo()
        {
            mazo.Clear();

            mazo.Add(new Carta("Mago Oscuro", 2500, 2100, 7, CardAttribute.Oscuridad, "Lanzador de Conjuros")
            { Imagen = Properties.Resources.mago });

            mazo.Add(new Carta("Héroe Elemental Neos", 2500, 2000, 7, CardAttribute.Luz, "Guerrero")
            { Imagen = Properties.Resources.Neos });

            mazo.Add(new Carta("Dragón Blanco de Ojos Azules", 3000, 2500, 8, CardAttribute.Luz, "Dragón")
            { Imagen = Properties.Resources.dragonAzul });

            mazo.Add(new Carta("Elfos Gemelos", 1900, 900, 4, CardAttribute.Luz, "Guerrero")
            { Imagen = Properties.Resources.elfosGemelos });

            mazo.Add(new Carta("Jinzo", 2400, 1500, 6, CardAttribute.Oscuridad, "Máquina")
            { Imagen = Properties.Resources.Jinzo });

            mazo.Add(new Carta("Kuriboh", 300, 200, 1, CardAttribute.Oscuridad, "Demonio")
            { Imagen = Properties.Resources.Kuriboh });

            mazo.Add(new Carta("Soldado Pingüino", 900, 800, 2, CardAttribute.Agua, "Aqua")
            { Imagen = Properties.Resources.Pingüino });

            mazo.Add(new Carta("Dragón Negro de Ojos Rojos", 2400, 2000, 7, CardAttribute.Oscuridad, "Dragón")
            { Imagen = Properties.Resources.blackDragon });

            mazo.Add(new Carta("Gaia el Caballero Feroz", 2300, 2100, 7, CardAttribute.Tierra, "Guerrero")
            { Imagen = Properties.Resources.Caballero });

            mazo.Add(new Carta("Skull Servant", 300, 200, 1, CardAttribute.Oscuridad, "Zombi")
            { Imagen = Properties.Resources.zombi });

            mazo.Add(new Carta("Cyber Dragon", 2100, 1600, 5, CardAttribute.Luz, "Máquina")
            { Imagen = Properties.Resources.cyberDragon });

            mazo.Add(new Carta("Buster Blader", 2600, 2300, 7, CardAttribute.Tierra, "Guerrero")
            { Imagen = Properties.Resources.blade });

            // Asignar Tag a cada picturebox
            for (int i = 0; i < 12; i++)
            {
                PictureBox pb = Controls.Find($"pictureBox{i + 1}", true).FirstOrDefault() as PictureBox;
                if (pb != null)
                    pb.Tag = mazo[i];
            }
        }

        private void ConfigurarEventosCartas()
        {
            for (int i = 1; i <= 12; i++)
            {
                PictureBox pb = Controls.Find($"pictureBox{i}", true).FirstOrDefault() as PictureBox;

                if (pb != null)
                {
                    pb.Click -= CartaSeleccionada_Click;
                    pb.Click += CartaSeleccionada_Click;

                    pb.MouseHover -= MostrarInfo_MouseHover;
                    pb.MouseHover += MostrarInfo_MouseHover;
                }
            }
        }

        private void MostrarInfo_MouseHover(object sender, EventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag is Carta carta)
            {
                string info = $"{carta.Nombre}\nATK: {carta.Ataque}  DEF: {carta.Defensa}";
                toolTip1.SetToolTip(pb, info);
            }
        }

        private void CartaSeleccionada_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag is Carta carta)
            {
                cartaJugador = carta;

                // seleccionar enemigo aleatorio
                Random rnd = new Random();
                Carta cartaEnemigo = mazo[rnd.Next(mazo.Count)];

                FormBatalla batalla = new FormBatalla(cartaJugador, cartaEnemigo);
                batalla.Show();
                this.Hide();
            }
        }
    }
}
