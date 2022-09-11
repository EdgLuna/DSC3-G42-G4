using System;
using CuidadoEquino.App.Dominio;
using CuidadoEquino.App.Persistencia;

namespace CuidadoEquino.App.Consola
{
    class Program

    {
        private static INRepositorioEquino _repositorioEquino = new RepositorioEquino(new Persistencia.AppContext());

        static void Main(string[] args)
        {
           Console.WriteLine("Hello, World!");
            AddEquino();
        }


        private static void AddEquino()
        {
            var equino = new Equino
            {
                Nombre = "Nicolay",
                FechaNacimiento= "01/06/2018",
                Genero = Genero.macho,
                Color = "Blanco",
                Raza = "Pony"


            };

            _repositorioEquino.AddEquino(equino);
        }

    }
}


