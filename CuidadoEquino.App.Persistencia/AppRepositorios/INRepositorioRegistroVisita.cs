using System.Collections.Generic;  //libreria donde se definen las interfaces
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface INRepositorioRegistroVisita
    {
        RegistroVisita AddRegistroVisita(RegistroVisita registroVisita);
        void DeleteRegistroVisita(int idregistroVisita);
        IEnumerable<RegistroVisita> GetAllRegistroVisitas(); //IEnumerable es un tipo defindo en C#
        RegistroVisita GetRegistroVisita(int idregistroVisita);
        RegistroVisita UpdateRegistroVisita(RegistroVisita registrovisita);
    } 
} 
