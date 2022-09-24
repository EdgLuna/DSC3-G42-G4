using System.Collections.Generic;  //libreria donde se definen las interfaces
using CuidadoEquino.App.Dominio;
 
namespace CuidadoEquino.App.Persistencia
{
    public interface INRepositorioHistoriaClinica
    {
        HistoriaClinica AddHistoriaClinica(HistoriaClinica hclinica);
        void DeleteHistoriaClinica(int idhclinica);
        IEnumerable<HistoriaClinica> GetAllHistoriasClinicas(); // IEnumetable es un tipo definido en c#
        HistoriaClinica GetHistoriaClinica(int idhclinica);
        HistoriaClinica UpdateHistoriaClinica(HistoriaClinica hclinica);
    } 
}