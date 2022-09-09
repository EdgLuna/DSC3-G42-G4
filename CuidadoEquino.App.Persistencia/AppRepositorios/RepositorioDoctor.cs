using System.Collections.Generic; 
using CuidadoEquino.App.Dominio;
using System.Linq;

namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioDoctor:INRepositorioDoctor
    {
        private readonly AppContext _AppContext; //instancia de Objeto de Clase AppContext
        public RepositorioDoctor (AppContext AppContext) //Cosntructor Clase RepositorioDoctor
        {
            _AppContext=AppContext;
        }
        Doctor INRepositorioDoctor.AddDoctor(Doctor doctor)
        {
            var DoctorAdicionado = _AppContext.Doctores.Add(doctor);
            _AppContext.SaveChanges();
            return DoctorAdicionado.Entity;
        }

/*
        void INRepositorioPaciente.DeletePaciente(int idpaciente)
        {
            var PacienteEncontrado = _AppContext.Pacientes.FirstOrDefault(p=>p.Id==idpaciente); //Id proviene de clase Persona por herencia
            if (PacienteEncontrado == null)
            {
                return;
            }
            _AppContext.Pacientes.Remove(PacienteEncontrado);
            _AppContext.SaveChanges();
        }

        IEnumerable<Paciente> INRepositorioPaciente.GetAllPacientes()
        {
            return _AppContext.Pacientes;
        }

        Paciente INRepositorioPaciente.GetPaciente(int idpaciente)
        {        
            var PacienteEncontrado = _AppContext.Pacientes.FirstOrDefault(p=>p.Id==idpaciente); //Id proviene de clase Persona por herencia
          
            return PacienteEncontrado;
        }

        Paciente INRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var PacienteEncontrado = _AppContext.Pacientes.FirstOrDefault(p=>p.Id==paciente.Id); //Id proviene de clase Persona por herencia
            if (PacienteEncontrado != null)
            {
                PacienteEncontrado.Nombre=paciente.Nombre;
                PacienteEncontrado.Apellidos=paciente.Apellidos;
                //Incluir demás Atributos
                _AppContext.SaveChanges();
            }
            return PacienteEncontrado;
        }
        */
    }
}