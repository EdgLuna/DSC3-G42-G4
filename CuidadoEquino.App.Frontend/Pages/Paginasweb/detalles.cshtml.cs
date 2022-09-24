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
    public class detallesModel : PageModel
    {
        private readonly INRepositorioEquino repositorioEquino;

        public Equino equino {get;set;}
        public detallesModel()
        {

            this.repositorioEquino = new RepositorioEquino(new
            CuidadoEquino.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int idequino)
        {
            equino = repositorioEquino.GetEquino(idequino);

            if (equino==null)

            {
                return RedirectToPage("./detalles");
        
            }

            else
            {
                return Page();


            }
        }


    }
}
