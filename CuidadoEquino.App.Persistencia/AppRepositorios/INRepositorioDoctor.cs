using System.Collections.Generic;  //22092022 a las 2200 juan y edgar
using CuidadoEquino.App.Dominio;
 
namespace CuidadoEquino.App.Persistencia
{
    public interface INRepositorioDoctor
    {
        Doctor AddDoctor(Doctor doctor);
        void DeleteDoctor(int iddoctor);
        IEnumerable<Doctor> GetAllDoctores(); // IEnumetable es un tipo definido en c#
        Doctor GetDoctor(int iddoctor);
        Doctor UpdateDoctor(Doctor doctor);
    }  
}