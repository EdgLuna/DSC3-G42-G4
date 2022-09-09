using System.Collections.Generic;  //libreria donde se definen las interfaces
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface INRepositorioDoctor
    {
        Doctor AddDoctor(Doctor doctor);
        void DeleteDoctor(int iddoctor);
        IEnumerable<Doctor> GetAllDoctores(); //IEnumerable es un tipo defindo en C#
        Doctor GetDoctor(int iddoctor);
        Doctor UpdateDoctor(Doctor doctor);
    } 
} 
