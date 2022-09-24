using System.Collections.Generic; 
using CuidadoEquino.App.Dominio;
using System.Linq;

namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioPropietario:INRepositorioPropietario
    {
        private readonly AppContext _AppContext; //instancia de Objeto de Clase AppContext
        public RepositorioPropietario( AppContext AppContext) //Cosntructor Clase RepositorioPaciente
        {
            _AppContext=AppContext;
        }
        Propietario INRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var PropietarioAdicionado = _AppContext.Propietarios.Add(propietario);
            _AppContext.SaveChanges();
            return PropietarioAdicionado.Entity;

        }
        
        void INRepositorioPropietario.DeletePropietario(int idpropietario)
        {
            var PropietarioEncontrado = _AppContext.Propietarios.FirstOrDefault(p=>p.Id==idpropietario); //Id proviene de clase Persona por herencia
            if (PropietarioEncontrado == null)
            {
                return;
            }
            _AppContext.Propietarios.Remove(PropietarioEncontrado);
            _AppContext.SaveChanges();
        }
        
        IEnumerable<Propietario> INRepositorioPropietario.GetAllPropietarios()
        {
            return _AppContext.Propietarios;
        }
        
        Propietario INRepositorioPropietario.GetPropietario(int idpropietario)
        {        
            var PropietarioEncontrado = _AppContext.Propietarios.FirstOrDefault(p=>p.Id==idpropietario); //Id proviene de clase Persona por herencia
          
            return PropietarioEncontrado;
        }
        
        Propietario INRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {
            var PropietarioEncontrado = _AppContext.Propietarios.FirstOrDefault(p=>p.Id==propietario.Id); //Id proviene de clase Persona por herencia
            if (PropietarioEncontrado != null)
            {
                PropietarioEncontrado.Nombres=propietario.Nombres;
                PropietarioEncontrado.Apellidos=propietario.Apellidos;
                PropietarioEncontrado.Direccion=propietario.Direccion;
                PropietarioEncontrado.Telefono=propietario.Telefono;
                PropietarioEncontrado.Correo=propietario.Correo;
                _AppContext.SaveChanges();
            }
            return PropietarioEncontrado;
        }
    }
}