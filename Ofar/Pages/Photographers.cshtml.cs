using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ofar.Pages
{
    public class PhotographersModel : PageModel
    {

        private readonly string[] photographers =
        {
            "Mary Ellen Mark", "Cindy Sherman", "Robert Frank", "Eliot Porter",
            "Imogen Cunningham", "Frans Lanting", "Paul Strand", "Weegee",
            "Richard Avedon", "Don McCullin", "Edward Western", "Man Ray",
            "David Bailey",  "David LaChapelle", "Anne Geddes", "Dorothea Lange",
            "Robert Doisneau", "Steve McCurry", "Mario Testino", "André Kertész",
            "Andreas Gursky", "Robert Mapplethorpe", "Henri-Cartier Bresson",
            "Annie Leibovitz", "Sebastião Salgado", "Brassaï", "Ansel Adams",
            "Robert Capa", "Camila Falquez", "Silvia Grav", "David Uzochukwu",
            "Alecsandra Raluca Dragoi", "Nadine Ijewere", "Nicholas Scarpinato",
            "Zev Hoover", "Oliver Charles", "Rachel Baran", "Lee Jeffries",
            "Katharina Jung", "Alex Stoddard", "Ailera Stone", "Evan Atwood",
            "Diane Sagnier", "Alex Benetel", "Isaac Hector", "Petra Collins",
            "Amanda Mustard", "Olivia Bee", "Jimmy Nelsson"
        };

        public IEnumerable<string> Photographers
        {
            get
            {
                return from p
                       in this.photographers
                       orderby p
                       select p;
            }
        }

        public void OnGet()
        {
            ViewData["Title"] = "Ofar Photography - Photographers";

        }
    }
}
