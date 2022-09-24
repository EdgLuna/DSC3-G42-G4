using System.Collections.Generic; 
using CuidadoEquino.App.Dominio;
using System.Linq;

namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioRegistroVisita:INRepositorioRegistroVisita
    {
        private readonly AppContext _AppContext; //instancia de Objeto de Clase AppContext
        public RepositorioRegistroVisita( AppContext AppContext) //Cosntructor Clase RepositorioPaciente
        {
            _AppContext=AppContext;
        }
        RegistroVisita INRepositorioRegistroVisita.AddRegistroVisita(RegistroVisita rvisita)
        {
            var RegistroVisitaAdicionada = _AppContext.RegistroVisitas.Add(rvisita);
            _AppContext.SaveChanges();
            return RegistroVisitaAdicionada.Entity;

        }
        
        void INRepositorioRegistroVisita.DeleteRegistroVisita(int idrvisita)
        {
            var RegistroVisitaEncontrado = _AppContext.RegistroVisitas.FirstOrDefault(p=>p.Id==idrvisita); //Id proviene de clase Persona por herencia
            if (RegistroVisitaEncontrado == null)
            {
                return;
            }
            _AppContext.RegistroVisitas.Remove(RegistroVisitaEncontrado);
            _AppContext.SaveChanges();
        }

        IEnumerable<RegistroVisita> INRepositorioRegistroVisita.GetAllRegistroVisitas()
        {
            return _AppContext.RegistroVisitas;
        }

        RegistroVisita INRepositorioRegistroVisita.GetRegistroVisita(int idrvisita)
        {        
            var RegistroVisitaEncontrado = _AppContext.RegistroVisitas.FirstOrDefault(p=>p.Id==idrvisita); //Id proviene de clase Persona por herencia
          
            return RegistroVisitaEncontrado;
        }

        RegistroVisita INRepositorioRegistroVisita.UpdateRegistroVisita(RegistroVisita rvisita)
        {
            var RegistroVisitaEncontrado = _AppContext.RegistroVisitas.FirstOrDefault(p=>p.Id==rvisita.Id); //Id proviene de clase Persona por herencia
            if (RegistroVisitaEncontrado != null)
            {
                RegistroVisitaEncontrado.Fecha=rvisita.Fecha;
                RegistroVisitaEncontrado.Temperatura=rvisita.Temperatura;
                RegistroVisitaEncontrado.Peso=rvisita.Peso;
                RegistroVisitaEncontrado.FrecuenciaCardiaca=rvisita.FrecuenciaCardiaca;
                RegistroVisitaEncontrado.FrecuenciaRespiratoria=rvisita.FrecuenciaRespiratoria;
                RegistroVisitaEncontrado.EstadoAnimo=rvisita.EstadoAnimo;
                RegistroVisitaEncontrado.Recomendaciones=rvisita.Recomendaciones;
                RegistroVisitaEncontrado.FormulaMedica=rvisita.FormulaMedica;                
                _AppContext.SaveChanges();
            }
            return RegistroVisitaEncontrado;
        }
    }
}