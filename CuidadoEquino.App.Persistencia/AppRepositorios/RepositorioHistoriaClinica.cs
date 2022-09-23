using System.Collections.Generic; 
using CuidadoEquino.App.Dominio;
using System.Linq;

namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioHistoriaClinica:INRepositorioHistoriaClinica
    {
        private readonly AppContext _AppContext; //instancia de Objeto de Clase AppContext
        public RepositorioHistoriaClinica (AppContext AppContext) //Cosntructor Clase RepositorioPaciente
        {
            _AppContext=AppContext;
        }
        HistoriaClinica INRepositorioHistoriaClinica.AddHistoriaClinica(HistoriaClinica hclinica )
        {
            var HistoriaClinicaAdicionada = _AppContext.HistoriasClinicas.Add(hclinica);
            _AppContext.SaveChanges();
            return HistoriaClinicaAdicionada.Entity;

        }
        
        void INRepositorioHistoriaClinica.DeleteHistoriaClinica(int idhclinica)
        {
            var HistoriaClinicaEncontrado = _AppContext.HistoriasClinicas.FirstOrDefault(p=>p.Id==idhclinica); //Id proviene de clase Persona por herencia
            if (HistoriaClinicaEncontrado == null)
            {
                return;
            }
            _AppContext.HistoriasClinicas.Remove(HistoriaClinicaEncontrado);
            _AppContext.SaveChanges();
        }
        
        IEnumerable<HistoriaClinica> INRepositorioHistoriaClinica.GetAllHistoriasClinicas()
        {
            return _AppContext.HistoriasClinicas;
        }

        HistoriaClinica INRepositorioHistoriaClinica.GetHistoriaClinica(int idhclinica)
        {        
            var HistoriaClinicaEncontrado = _AppContext.HistoriasClinicas.FirstOrDefault(p=>p.Id==idhclinica); //Id proviene de clase Persona por herencia
          
            return HistoriaClinicaEncontrado;
        }

         HistoriaClinica INRepositorioHistoriaClinica.UpdateHistoriaClinica(HistoriaClinica hclinica)
        {
            var HistoriaClinicaEncontrado = _AppContext.HistoriasClinicas.FirstOrDefault(p=>p.Id==hclinica.Id); //Id proviene de clase Persona por herencia
            if (HistoriaClinicaEncontrado != null)
            {
                HistoriaClinicaEncontrado.Fecha=hclinica.Fecha;
                HistoriaClinicaEncontrado.Id_Propietario=hclinica.Id_Propietario;
                HistoriaClinicaEncontrado.Id_Visita=hclinica.Id_Visita;
                _AppContext.SaveChanges();
            }
            return HistoriaClinicaEncontrado;
            
        }
    }
}