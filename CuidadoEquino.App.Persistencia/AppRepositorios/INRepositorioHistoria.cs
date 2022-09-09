using System.Collections.Generic;  //libreria donde se definen las interfaces
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface INRepositorioHistoria
    {
        Historia AddHistoria(Historia historia);
        void DeleteHistoria(int idhistoria);
        IEnumerable<Historia> GetAllHistorias(); //IEnumerable es un tipo defindo en C#
        Historia GetHistoria(int idhistoria);
        Historia UpdateHistoria(Historia historia);
    } 
} 
