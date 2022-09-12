using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuidadoEquino.App.Frontend.Pages
{
    public class listasModel2 : PageModel
    {
        public string[ ] vectorLista2 = { "Cédula", "Nombres",
        "Apellidos" , "Dirección" , "Telefono", "Tarjeta Profesional"};
        
        public List<string>mylista2{get;set;}
        public void OnGet()
        {
          
          mylista2 = new List<string>();
          mylista2.AddRange(vectorLista2);

        }
    }
}
