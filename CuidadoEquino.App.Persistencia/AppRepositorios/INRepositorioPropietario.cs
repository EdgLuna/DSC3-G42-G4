using System.Collections.Generic;  //libreria donde se definen las interfaces
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface INRepositorioPropietario
    {
        Propietario AddPropietario(Propietario propietario);
        void DeletePropietario(int idpropietario);
        IEnumerable<Propietario> GetAllPropietarios(); //IEnumerable es un tipo defindo en C#
        Propietario GetPropietario(int idpropietario);
        Propietario UpdatePropietario(Propietario propietario);
    } 
} 
