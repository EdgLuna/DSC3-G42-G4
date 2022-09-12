using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuidadoEquino.App.Frontend.Pages
{
    public class listasModel1 : PageModel
    {
        public string[ ] vectorLista1 = { "Cédula", "Nombres",
        "Apellidos" , "Dirección" , "Telefono", "Correo"};
        
        public List<string>mylista1{get;set;}
        public void OnGet()
        {
          
          mylista1 = new List<string>();
          mylista1.AddRange(vectorLista1);

        }
    }
}