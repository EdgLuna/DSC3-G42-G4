using System.Collections.Generic; 
using CuidadoEquino.App.Dominio;
using System.Linq;

namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioHistoria:INRepositorioHistoria
    {
        private readonly AppContext _AppContext; //instancia de Objeto de Clase AppContext
        public RepositorioHistoria (AppContext AppContext) //Cosntructor Clase RepositorioHistoria
        {
            _AppContext=AppContext;
        }
        Historia INRepositorioHistoria.AddHistoria(Historia historia)
        {
            var HistoriaAdicionado = _AppContext.Historias.Add(historia);
            _AppContext.SaveChanges();
            return HistoriaAdicionado.Entity;
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