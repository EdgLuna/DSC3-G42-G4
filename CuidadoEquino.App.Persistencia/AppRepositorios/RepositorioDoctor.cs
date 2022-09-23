using System.Collections.Generic; 
using CuidadoEquino.App.Dominio;
using System.Linq;

namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioDoctor:INRepositorioDoctor
    {
        private readonly AppContext _AppContext; //instancia de Objeto de Clase AppContext
        public RepositorioDoctor (AppContext AppContext) //Cosntructor Clase RepositorioPaciente
        {
            _AppContext=AppContext;
        }
        Doctor INRepositorioDoctor.AddDoctor(Doctor doctor)
        {
            var DoctorAdicionado = _AppContext.Doctores.Add(doctor);
            _AppContext.SaveChanges();
            return DoctorAdicionado.Entity;

        }
        
        void INRepositorioDoctor.DeleteDoctor(int iddoctor)
        {
            var DoctorEncontrado = _AppContext.Doctores.FirstOrDefault(p=>p.Id==iddoctor); //Id proviene de clase Persona por herencia
            if (DoctorEncontrado == null)
            {
                return;
            }
            _AppContext.Doctores.Remove(DoctorEncontrado);
            _AppContext.SaveChanges();
        }

        IEnumerable<Doctor> INRepositorioDoctor.GetAllDoctores()
        {
            return _AppContext.Doctores;
        }

        Doctor INRepositorioDoctor.GetDoctor(int iddoctor)
        {        
            var DoctorEncontrado = _AppContext.Doctores.FirstOrDefault(p=>p.Id==iddoctor); //Id proviene de clase Persona por herencia
          
            return DoctorEncontrado;
        }

        Doctor INRepositorioDoctor.UpdateDoctor(Doctor doctor)
        {
            var DoctorEncontrado = _AppContext.Doctores.FirstOrDefault(p=>p.Id==doctor.Id); //Id proviene de clase Persona por herencia
            if (DoctorEncontrado != null)
            {
                DoctorEncontrado.Nombres=doctor.Nombres;
                DoctorEncontrado.Apellidos=doctor.Apellidos;
                DoctorEncontrado.Direccion=doctor.Direccion;
                DoctorEncontrado.Telefono=doctor.Telefono;
                DoctorEncontrado.TarjetaProfesional=doctor.TarjetaProfesional;
                _AppContext.SaveChanges();
            }
            return DoctorEncontrado;
        }
    }
}