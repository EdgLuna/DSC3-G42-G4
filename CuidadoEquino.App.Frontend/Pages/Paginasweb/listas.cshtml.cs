using Microsoft.AspNetCore.Mvc;


using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuidadoEquino.App.Frontend.Pages
{
    public class listasModel : PageModel
    {
        public string[ ] vectorLista = { "Nombre", "Fecha de nacimiento",
        "Género" , "Color" , "Raza"};
        
        public List<string>mylista{get;set;}
        public void OnGet()
        {
          
          mylista = new List<string>();
          mylista.AddRange(vectorLista);

        }



        }
    }

