using System;

namespace Sistema_de_Gestión_de_Trámites
{
    public class Tramite
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaHora { get; set; }

        public Tramite() { }

        public Tramite(string dni, string nombre, string tipo)
        {
            DNI = dni;
            Nombre = nombre;
            Tipo = tipo;
            FechaHora = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{FechaHora:HH:mm} - {DNI} - {Nombre} - {Tipo}";
        }
    }
}
