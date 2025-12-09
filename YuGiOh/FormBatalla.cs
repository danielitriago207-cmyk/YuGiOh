using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YuGiOh
{
    public partial class FormBatalla : Form
    {
        private Carta cartaJugador;
        private Carta cartaEnemigo;

        private int playerLP = 8000;
        private int enemiLP = 8000;

        public FormBatalla(Carta jugador, Carta enemigo)
        {
            InitializeComponent();

            this.cartaJugador = jugador;
            this.cartaEnemigo = enemigo;

            CargarCartasVisuales();
            ActualizarLP();
            Registrar("DUELO INICIADO");
        }

        // ============================
        //  VISUAL
        // ============================

        private void CargarCartasVisuales()
        {
            // Si usas imágenes físicas, aquí las asignas
            // pictureBoxPlayer.Image = Image.FromFile(cartaJugador.RutaImagen);

            pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEnemi.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlayer.Image = cartaJugador.Imagen;
            pictureBoxEnemi.Image = cartaEnemigo.Imagen;

            pictureBoxPlayer.Tag = cartaJugador;
            pictureBoxEnemi.Tag = cartaEnemigo;

            // Mostrar valores al pasar el mouse
            pictureBoxPlayer.MouseHover += (s, e) =>
            {
                toolTip1.SetToolTip(pictureBoxPlayer, cartaJugador.ObtenerInfoCompleta());
            };

            pictureBoxEnemi.MouseHover += (s, e) =>
            {
                toolTip1.SetToolTip(pictureBoxEnemi, cartaEnemigo.ObtenerInfoCompleta());
            };

            Registrar($"Tu carta es: {cartaJugador.Nombre} (ATK {cartaJugador.Ataque})");
            Registrar($"Carta enemiga: {cartaEnemigo.Nombre} (ATK {cartaEnemigo.Ataque})");
        }

        private void ActualizarLP()
        {
            lblPlayerLP.Text = playerLP.ToString();
            lblEnemiLP.Text = enemiLP.ToString();
        }

        private void Registrar(string msg)
        {
            textBox1.AppendText(msg + Environment.NewLine);
        }

        // ============================
        //  BOTÓN: ATAQUE
        // ============================

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            Registrar($"--- ATACAS CON {cartaJugador.Nombre} ---");

            if (cartaJugador.Posicion == CardPosition.Defensa)
            {
                Registrar("No puedes atacar en posición de defensa.");
                return;
            }

            int daño = cartaJugador.Ataque - cartaEnemigo.Ataque;

            if (daño > 0)
            {
                enemiLP -= daño;
                Registrar($"Ataque exitoso. El enemigo recibe {daño} de daño.");
            }
            else if (daño < 0)
            {
                playerLP += daño; // daño es negativo
                Registrar($"Tu carta pierde. Recibes {-daño} de daño.");
            }
            else
            {
                Registrar("Los ATK son iguales. Nadie recibe daño.");
            }

            ActualizarLP();
            VerificarFinDeJuego();
        }

        // ============================
        //  BOTÓN: DEFENDER
        // ============================

        private void btnDefender_Click(object sender, EventArgs e)
        {
            cartaJugador.Posicion = CardPosition.Defensa;
            Registrar($"{cartaJugador.Nombre} ahora está en DEFENSA.");
        }

        // ============================
        //  BOTÓN: CAMBIAR POSICIÓN
        // ============================

        private void btnCambiarPos_Click(object sender, EventArgs e)
        {
            if (cartaJugador.Posicion == CardPosition.Ataque)
            {
                cartaJugador.Posicion = CardPosition.Defensa;
                Registrar($"{cartaJugador.Nombre} fue colocado en DEFENSA.");
            }
            else
            {
                cartaJugador.Posicion = CardPosition.Ataque;
                Registrar($"{cartaJugador.Nombre} fue colocado en ATAQUE.");
            }
        }

        // ============================
        //  FIN DE DUELO
        // ============================

        private void VerificarFinDeJuego()
        {
            if (enemiLP <= 0)
            {
                Registrar("🎉 ¡HAS GANADO EL DUELO!");
                MessageBox.Show("¡GANASTE!", "Victoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            if (playerLP <= 0)
            {
                Registrar("💀 Has perdido el duelo.");
                MessageBox.Show("Perdiste...", "Derrota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }
    }
}
