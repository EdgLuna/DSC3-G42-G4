using System;
namespace CuidadoEquino.App.Dominio
{
    public class Equino
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string FechaNacimiento {get; set;}
        public Genero Genero {get; set;}
        public string Color {get; set;}
        public string Raza {get; set;}
    }
}