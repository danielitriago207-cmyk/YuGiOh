using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOh
{
    public enum CardPosition { Ataque, Defensa }
    public enum CardAttribute { Luz, Oscuridad, Tierra, Viento, Agua, Fuego, Desconocido }

    public class Carta
    {
        // ATRIBUTOS/ENCAPSULAMIENTO
        // Ya tienes propiedades públicas - esto cumple el encapsulamiento
        public string Nombre { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int Nivel { get; set; }
        public CardAttribute Atributo { get; set; }
        public string Tipo { get; set; }
        public CardPosition Posicion { get; set; }
        public bool EnCampo { get; set; }
        public bool Girada { get; set; }
        public string RutaImagen { get; set; } = null;

        //CONSTRUCTORES
        // Constructor vacío 
        public Carta()
        {
            Nombre = "Carta Desconocida";
            Ataque = 0;
            Defensa = 0;
            Nivel = 1;
            Atributo = CardAttribute.Desconocido;
            Tipo = "Desconocido";
            Posicion = CardPosition.Ataque;
        }

        // Constructor completo 
        public Carta(string nombre, int ataque, int defensa, int nivel, CardAttribute atributo, string tipo)
        {
            Nombre = nombre;
            Ataque = ataque;
            Defensa = defensa;
            Nivel = nivel;
            Atributo = atributo;
            Tipo = tipo;
            Posicion = CardPosition.Ataque;
        }


        //MÉTODOS REQUERIDOS

        // MÉTODO 1: Ataca
        public void Ataca()
        {
            Console.WriteLine($"El monstruo {Nombre} atacará con {Ataque} puntos");
        }

        // MÉTODO 2: Defiende
        public void Defiende()
        {
            Console.WriteLine($"El monstruo {Nombre} defenderá con {Defensa} puntos");
        }

        // MÉTODO 3: Colocar en posición 
        public void ColocarEnPosicion(string posicionTexto)
        {
            if (posicionTexto.ToLower() == "ataque")
            {
                Posicion = CardPosition.Ataque;
                Console.WriteLine($"La carta {Nombre} fue colocada en ataque");
            }
            else if (posicionTexto.ToLower() == "defensa")
            {
                Posicion = CardPosition.Defensa;
                Console.WriteLine($"La carta {Nombre} fue colocada en defensa");
            }
            else
            {
                Console.WriteLine("Posición no válida. Use 'Ataque' o 'Defensa'");
            }
        }

        // Versión alternativa usando enum
        public void CambiarPosicion(CardPosition nuevaPosicion)
        {
            Posicion = nuevaPosicion;
            Console.WriteLine($"La carta {Nombre} fue colocada en {Posicion.ToString().ToLower()}");
        }

        // MÉTODO 4: Mostrar todos los atributos - REQUERIDO
        public void MostrarAtributos()
        {
            Console.WriteLine("=== INFORMACIÓN COMPLETA DE LA CARTA ===");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Ataque: {Ataque}");
            Console.WriteLine($"Defensa: {Defensa}");
            Console.WriteLine($"Nivel: {Nivel}");
            Console.WriteLine($"Atributo: {Atributo}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Posición: {Posicion}");
            Console.WriteLine($"En campo: {EnCampo}");
            Console.WriteLine($"Girada: {Girada}");
            Console.WriteLine($"Ruta imagen: {RutaImagen ?? "No tiene"}");
            Console.WriteLine("========================================");
        }

        

        // Mostrar datos en una línea
        public string MostrarDatos()
        {
            return $"Nombre: {Nombre} | ATK:{Ataque} DEF:{Defensa} | Nivel:{Nivel} | Atributo:{Atributo} | Tipo:{Tipo} | Pos:{Posicion}";
        }

        // Para formularios (información completa)
        public string ObtenerInfoCompleta()
        {
            return $"Nombre: {Nombre}\n" +
                   $"ATK: {Ataque} | DEF: {Defensa}\n" +
                   $"Nivel: {Nivel}\n" +
                   $"Atributo: {Atributo}\n" +
                   $"Tipo: {Tipo}\n" +
                   $"Posición: {Posicion}\n" +
                   $"En campo: {(EnCampo ? "Sí" : "No")}\n" +
                   $"Girada: {(Girada ? "Sí" : "No")}";
        }

        // Para formularios (información resumida)
        public string ObtenerInfoResumida()
        {
            return $"{Nombre}\nATK: {Ataque} | DEF: {Defensa}\nNivel: {Nivel} | {Atributo} | {Tipo}";
        }

        public override string ToString()
        {
            return $"{Nombre} (ATK:{Ataque}/DEF:{Defensa})";
        }
    }
}