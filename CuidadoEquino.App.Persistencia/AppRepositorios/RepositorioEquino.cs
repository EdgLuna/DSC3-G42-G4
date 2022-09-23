using System.Collections.Generic; 
using CuidadoEquino.App.Dominio;
using System.Linq;

namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioEquino:INRepositorioEquino
    {
        private readonly AppContext _AppContext; //instancia de Objeto de Clase AppContext
        public RepositorioEquino (AppContext AppContext) //Cosntructor Clase RepositorioPaciente
        {
            _AppContext=AppContext;
        }
        Equino INRepositorioEquino.AddEquino(Equino equino)
        {
            var EquinoAdicionado = _AppContext.Equinos.Add(equino);
            _AppContext.SaveChanges();
            return EquinoAdicionado.Entity;

        }
         void INRepositorioEquino.DeleteEquino(int idequino)
        {
            var EquinoEncontrado = _AppContext.Equinos.FirstOrDefault(p=>p.Id==idequino); //Id proviene de clase Persona por herencia
            if (EquinoEncontrado == null)
            {
                return;
            }
            _AppContext.Equinos.Remove(EquinoEncontrado);
            _AppContext.SaveChanges();
        }


        IEnumerable<Equino> INRepositorioEquino.GetAllEquinos()
        {
      
            return _AppContext.Equinos;

        }
       
        Equino INRepositorioEquino.GetEquino(int idequino)
        {

            return _AppContext.Equinos.FirstOrDefault(e => e.Id ==idequino);
        }
         Equino INRepositorioEquino.UpdateEquino(Equino equino)
        {
            var EquinoEncontrado = _AppContext.Equinos.FirstOrDefault(p=>p.Id==equino.Id); //Id proviene de clase Persona por herencia
            if (EquinoEncontrado != null)
            {
                EquinoEncontrado.Nombre=equino.Nombre;
                EquinoEncontrado.FechaNacimiento=equino.FechaNacimiento;
                EquinoEncontrado.Color=equino.Color;
                EquinoEncontrado.Genero=equino.Genero;
                EquinoEncontrado.Raza=equino.Raza;                
                _AppContext.SaveChanges();
            }
            return EquinoEncontrado;
        }
    }
}