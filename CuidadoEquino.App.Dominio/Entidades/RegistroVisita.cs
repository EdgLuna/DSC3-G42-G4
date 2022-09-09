using System;
namespace CuidadoEquino.App.Dominio
{
    public class RegistroVisita
    {
        public int Id {get; set;}
        public string Fecha {get; set;}
        public string Temperatura {get; set;}
        public string Peso {get; set;}
        public string FrecuenciaCardiaca {get; set;}
        public string FrecuenciaRespiratoria {get; set;}
        public string EstadoAnimo {get; set;}
        public string Recomendaciones {get; set;}
        public string FormulaMedica {get; set;}
    }
}