using System.Collections.Generic;  //libreria donde se definen las interfaces
using CuidadoEquino.App.Dominio;
 
namespace CuidadoEquino.App.Persistencia
{
    public interface INRepositorioEquino
    {
        Equino AddEquino(Equino equino);
        /*
        void DeletePaciente(int idpaciente);
        Paciente UpdatePaciente(Paciente paciente);
        */

        Equino GetEquino(int idequino);
        IEnumerable<Equino> GetAllEquinos(); // IEnumetable es un tipo definido en c#
    }
 
}