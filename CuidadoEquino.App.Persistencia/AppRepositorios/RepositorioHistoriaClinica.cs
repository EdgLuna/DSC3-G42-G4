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

    }
}