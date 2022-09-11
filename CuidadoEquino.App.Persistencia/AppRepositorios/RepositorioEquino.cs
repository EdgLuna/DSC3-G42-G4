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

        IEnumerable<Equino> INRepositorioEquino.GetAllEquinos()
        {
      
            return _AppContext.Equinos;

        }
       
        Equino INRepositorioEquino.GetEquino(int idequino)
        {

            return _AppContext.Equinos.FirstOrDefault(e => e.Id ==idequino);
        }





    }
}