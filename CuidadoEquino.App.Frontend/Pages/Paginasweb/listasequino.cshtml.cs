using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CuidadoEquino.App.Dominio;
using CuidadoEquino.App.Persistencia;
using Microsoft.AspNetCore.Authorization;
//librerias

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuidadoEquino.App.Frontend.Pages
{
    public class listasequinoModel : PageModel
    {

        public readonly INRepositorioEquino repositorioEquino;

        public IEnumerable<Equino> Equino{get;set;}

        public listasequinoModel()
        {
            this.repositorioEquino = new RepositorioEquino(new
            CuidadoEquino.App.Persistencia.AppContext());

        }



        public void OnGet( string filtroBusqueda)
        {
            Equino = repositorioEquino.GetAllEquinos();
        }
    }
}
