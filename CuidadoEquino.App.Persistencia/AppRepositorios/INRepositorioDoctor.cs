using System.Collections.Generic;  //libreria donde se definen las interfaces
using CuidadoEquino.App.Dominio;
 
namespace CuidadoEquino.App.Persistencia
{
    public interface INRepositorioDoctor
    {
        Doctor AddDoctor(Doctor doctor);
       // void DeletePaciente(int idpaciente);
        //IEnumerable<Paciente> GetAllPacientes(); // IEnumetable es un tipo definido en c#
       // Paciente GetPaciente(int idpaciente);
       // Paciente UpdatePaciente(Paciente paciente);
    }
 
    
 
}