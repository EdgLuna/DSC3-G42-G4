using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuidadoEquino.App.Frontend.Pages
{
    public class listasModel : PageModel
    {
        public string[ ] vectorLista = { "Ingreso Equino", "Ingreso Veterinario",
        "Ingreso Propietario" , "Ingreso Registro Visita" , "Consultar Historia Cliníca"};
        
        public List<string>mylista{get;set;}
        public void OnGet()
        {
          
          mylista = new List<string>();
          mylista.AddRange(vectorLista);

        }
    }
}
