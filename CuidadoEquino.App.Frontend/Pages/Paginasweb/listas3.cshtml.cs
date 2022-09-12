using Microsoft.AspNetCore.Mvc;


using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuidadoEquino.App.Frontend.Pages
{
    public class listasModel3 : PageModel
    {
        public string[ ] vectorLista = { "Nombre", "Fecha de nacimiento",
        "Género" , "Color" , "Raza"};
        
        public List<string>mylista3{get;set;}
        public void OnGet()
        {
          
          mylista3 = new List<string>();
          mylista3.AddRange(vectorLista);

        }



        }
    }
