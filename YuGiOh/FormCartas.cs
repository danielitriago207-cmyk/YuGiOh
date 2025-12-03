using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YuGiOh
{
    public partial class FormCartas : Form
    {
        int cartasSeleccionadas = 0;
        private List<Carta> mazo = new List<Carta>();
        public FormCartas()
        {
            InitializeComponent();
            InicializarMazo();           //Crear las 12 cartas
            ConfigurarEventosCartas();
        }
        private void InicializarMazo()
        {
            mazo.Clear();

            // Tus 12 cartas
           
            mazo.Add(new Carta("Mago Oscuro", 2500, 2100, 7, CardAttribute.Oscuridad, "Lanzador de Conjuros"));

            mazo.Add(new Carta("Héroe Elemental Neos", 2500, 2000, 7, CardAttribute.Luz, "Guerrero"));

            mazo.Add(new Carta("Dragón Blanco de Ojos Azules", 3000, 2500, 8, CardAttribute.Luz, "Dragón"));

            mazo.Add(new Carta("Elfos Gemelos", 1900, 900, 4, CardAttribute.Luz, "Guerrero"));

            mazo.Add(new Carta("Jinzo", 2400, 1500, 6, CardAttribute.Oscuridad, "Máquina"));
            
            mazo.Add(new Carta("Kuriboh", 300, 200, 1, CardAttribute.Oscuridad, "Demonio"));

            mazo.Add(new Carta("Soldado Pingüino", 900, 800, 2, CardAttribute.Agua, "Aqua"));

            mazo.Add(new Carta("Dragón Negro de Ojos Rojos", 2400, 2000, 7, CardAttribute.Oscuridad, "Dragón"));

            mazo.Add(new Carta("Gaia el Caballero Feroz", 2300, 2100, 7, CardAttribute.Tierra, "Guerrero"));

            mazo.Add(new Carta("Skull Servant", 300, 200, 1, CardAttribute.Oscuridad, "Zombi"));

            mazo.Add(new Carta("Cyber Dragon", 2100, 1600, 5, CardAttribute.Luz, "Máquina"));

            mazo.Add(new Carta("Buster Blader", 2600, 2300, 7, CardAttribute.Tierra, "Guerrero"));

            // Asignar cada carta a su PictureBoxx
            for (int i = 0; i < mazo.Count && i < 12; i++)
            {
                PictureBox pb = Controls.Find($"pictureBox{i + 1}", true).FirstOrDefault() as PictureBox;
                if (pb != null)
                {
                    pb.Tag = mazo[i];  // Guardar la carta en el Tag
                }
            }
        }
        //CONFIGURAR EVENTOS UNIFICADOS 
        private void ConfigurarEventosCartas()
        {
            // Crear un solo evento para todos los PictureBox
            for (int i = 1; i <= 12; i++)
            {
                if (Controls.Find($"pictureBox{i}", true).FirstOrDefault() is PictureBox pb)
                {
                    // Remover eventos previos para evitar duplicados
                    pb.MouseHover -= MostrarInfoCarta_MouseHover;
                    pb.Click -= MostrarDetalleCarta_Click;

                    // Agregar nuevos eventos
                    pb.MouseHover += MostrarInfoCarta_MouseHover;
                    pb.Click += MostrarDetalleCarta_Click;
                }
            }
        }
        //EVENTO MOUSEHOVER UNIFICADO 
        private void MostrarInfoCarta_MouseHover(object sender, EventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag is Carta carta)
            {
                // Usar el ToolTip con información REAL de la carta
                string info = $"Nombre: {carta.Nombre}\n" +
                             $"ATK: {carta.Ataque} | DEF: {carta.Defensa}\n" +
                             $"Tipo: {carta.Tipo}\n" +
                             $"Nivel: {carta.Nivel}";

                toolTip1.SetToolTip(pb, info);

                // También puedes mostrarlo en un Label si tienes
                // Ejemplo: lblInfo.Text = info;
            }
        }
        //EVENTO CLICK PARA DETALLES 
        private void MostrarDetalleCarta_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag is Carta carta)
            {
                // Mostrar información COMPLETA en un MessageBox
                string infoCompleta = carta.ObtenerInfoCompleta();
                MessageBox.Show(infoCompleta, $"Información: {carta.Nombre}",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //BOTÓN PARA PROBAR FUNCIONALIDADES 
        private void btnProbar_Click(object sender, EventArgs e)
        {
            // Probar la primera carta
            if (mazo.Count > 0)
            {
                Carta primeraCarta = mazo[0];

                // Usar los métodos requeridos
                primeraCarta.Ataca();
                primeraCarta.Defiende();
                primeraCarta.ColocarEnPosicion("Defensa");

                // Mostrar atributos en consola
                primeraCarta.MostrarAtributos();

                // Mostrar mensaje en pantalla
                MessageBox.Show("Métodos probados en consola (ver la ventana de Output)",
                    "Prueba Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== MAZO COMPLETO (12 cartas) ===");
            sb.AppendLine();

            foreach (Carta carta in mazo)
            {
                sb.AppendLine($"• {carta.Nombre}");
                sb.AppendLine($"  ATK: {carta.Ataque} | DEF: {carta.Defensa} | Nivel: {carta.Nivel}");
                sb.AppendLine($"  Tipo: {carta.Tipo} | Atributo: {carta.Atributo}");
                sb.AppendLine();
            }

            MessageBox.Show(sb.ToString(), "Todas las Cartas del Mazo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProbarMetodos_Click(object sender, EventArgs e)
        {
            // 1. Crear una carta de prueba
            Carta cartaPrueba = new Carta("Dragón Blanco de Ojos Azules", 3000, 2500, 8, CardAttribute.Luz, "Dragón");

            // 2. Probar TODOS los métodos
            Console.WriteLine("=== INICIANDO PRUEBAS ===");

            // a) Probar método Ataca()
            cartaPrueba.Ataca();  // Debería mostrar: "El monstruo Dragón Blanco... atacará con 3000 puntos"

            // b) Probar método Defiende()
            cartaPrueba.Defiende();  // Debería mostrar: "El monstruo Dragón Blanco... defenderá con 2500 puntos"

            // c) Probar cambiar posición
            cartaPrueba.ColocarEnPosicion("Defensa");  // "La carta Dragón Blanco... fue colocada en defensa"
            cartaPrueba.ColocarEnPosicion("Ataque");   // "La carta Dragón Blanco... fue colocada en ataque"

            // d) Probar método MostrarAtributos()
            cartaPrueba.MostrarAtributos();  // Debería mostrar todos los atributos

            // 3. Probar con otra carta
            Carta carta2 = new Carta("Kuriboh", 300, 200, 1, CardAttribute.Oscuridad, "Demonio");
            carta2.Ataca();
            carta2.Defiende();

            Console.WriteLine("=== PRUEBAS COMPLETADAS ===");

            // 4. Mostrar mensaje en pantalla
            MessageBox.Show("Pruebas completadas. Revisa la ventana de CONSOLA (Output)",
                            "✅ Pruebas exitosas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

    }
}
