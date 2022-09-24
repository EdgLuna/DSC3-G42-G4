using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CuidadoEquino.App.Dominio;
using CuidadoEquino.App.Persistencia;

//librerias opcionales
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuidadoEquino.App.Frontend.Pages
{
    public class editarModel : PageModel
    {
        private readonly INRepositorioEquino repositorioEquino;
        [BindProperty]
        public Equino Equino { set; get; }
        public editarModel()
        {
            this.repositorioEquino = new RepositorioEquino(new CuidadoEquino.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int idequino)
        {

            Equino = repositorioEquino.GetEquino(idequino);
            if (Equino == null)
            {
                return RedirectToPage("./NoFound");
            }
            else
            {
                return Page();
                
            }
        }

        public IActionResult OnPost()
        {
             Equino=repositorioEquino.UpdateEquino(Equino);
          
            return RedirectToPage("./listasequino"); 
        }

    }
}
