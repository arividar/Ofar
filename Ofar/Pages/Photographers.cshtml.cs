using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ofar.Pages
{
    public class PhotographersModel : PageModel
    {
        public IEnumerable<string> Photographers { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Ofar Photography - Photographers";
            Photographers = new[] 
            { 
                "Mary Ellen Mark", "Cindy Sherman", "Robert Frank", "Eliot Porter",
                "Imogen Cunningham", "Frans Lanting", "Paul Strand", "Weegee",  
                "Richard Avedon", "Don McCullin", "Edward Western", "Man Ray", 
                "David Bailey",  "David LaChapelle", "Anne Geddes", "Dorothea Lange", 
                "Robert Doisneau", "Steve McCurry", "Mario Testino", "André Kertész", 
                "Andreas Gursky", "Robert Mapplethorpe", "Henri-Cartier Bresson", 
                "Annie Leibovitz", "Sebastião Salgado", "Brassaï", "Ansel Adams", 
                "Robert Capa" 
            };
        }
    }
}
