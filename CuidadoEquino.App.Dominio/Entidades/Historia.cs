using System;
namespace CuidadoEquino.App.Dominio
{
    public class Historia
    {
        public int Id {get; set;}
        public string Fecha {get; set;}
        public int Id_Propietario {get; set;}
        public int Id_Visita {get; set;}
    }
}