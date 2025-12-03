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

        // Constructor solo nombre
        public Carta(string nombre)
        {
            Nombre = nombre;
            Ataque = 0;
            Defensa = 0;
            Nivel = 1;
            Atributo = CardAttribute.Desconocido;
            Tipo = "Desconocido";
            Posicion = CardPosition.Ataque;
        }

        // Constructor nombre + atk + def
        public Carta(string nombre, int ataque, int defensa)
        {
            Nombre = nombre;
            Ataque = ataque;
            Defensa = defensa;
            Nivel = 1;
            Atributo = CardAttribute.Desconocido;
            Tipo = "Desconocido";
            Posicion = CardPosition.Ataque;
        }

        public void Ataca()
        {
            Console.WriteLine($"El monstruo {Nombre} atacará con {Ataque} puntos");
        }

        public void Defiende()
        {
            Console.WriteLine($"El monstruo {Nombre} defenderá con {Defensa} puntos");
        }

        public void CambiarPosicion(CardPosition nueva)
        {
            Posicion = nueva;
            Console.WriteLine($"La carta {Nombre} fue colocada en {Posicion}");
        }

        public string MostrarDatos()
        {
            return $"Nombre: {Nombre} | ATK:{Ataque} DEF:{Defensa} | Nivel:{Nivel} | Atributo:{Atributo} | Tipo:{Tipo} | Pos:{Posicion}";
        }

        public override string ToString()
        {
            return $"{Nombre} (ATK:{Ataque} DEF:{Defensa})";
        }
    }
}
