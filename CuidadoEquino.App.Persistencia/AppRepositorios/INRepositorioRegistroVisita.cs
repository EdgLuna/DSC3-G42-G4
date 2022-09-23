using System.Collections.Generic;  //libreria donde se definen las interfaces
using CuidadoEquino.App.Dominio;
 
namespace CuidadoEquino.App.Persistencia
{
    public interface INRepositorioRegistroVisita
    {
        RegistroVisita AddRegistroVisita(RegistroVisita rvisita);
        void DeleteRegistroVisita(int idrvisita);
        IEnumerable<RegistroVisita>GetAllRegistroVisitas(); // IEnumetable es un tipo definido en c#
        RegistroVisita GetRegistroVisita(int idrvisita);
        RegistroVisita UpdateRegistroVisita(RegistroVisita rvisita);
    } 
}