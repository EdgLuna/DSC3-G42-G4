using System.Collections.Generic;  //libreria donde se definen las interfaces
using CuidadoEquino.App.Dominio;
 
namespace CuidadoEquino.App.Persistencia
{
    public interface INRepositorioEquino
    {
        Equino AddEquino(Equino equino);
        void DeleteEquino(int idequino);
        IEnumerable<Equino> GetAllEquinos(); // IEnumetable es un tipo definido en c#
        Equino GetEquino(int idequino);
        Equino UpdateEquino(Equino equino);
    }
 
}