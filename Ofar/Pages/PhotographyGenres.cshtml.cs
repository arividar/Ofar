using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ofar.Pages
{
    public class PhotographyGenresModel : PageModel
    {
        private readonly string[] photographyGenres =
        {
            // See: https://expertphotography.com/types-of-photography

            "Abstract", "Adventure", "Aerial", "Architectural", "Astro", 
            "Baby", "Beauty", "Children", "Boudoir", "Candid", "Cityscape", 
            "Composite", "Commercial", "Creative", "Documentary", "Drone",
            "Conceptual", "Editorial", "Event", "Family", "Fashion", "Fine art", 
            "Food", "Golden Hour", "Indoor", "Infrared", "Interior", "Landscape", 
            "Lifestyle", "Long Exposure", "Macro", "Milky Way", "Minimalist", 
            "Mobile", "Newborn", "Night", "Pet", "Photojournalism", "Portrait", 
            "Product", "Real Estate", "Seascape", "Social Media", "Sports", 
            "Still-Life", "Street", "Studio", "Time-Lapse", "Travel", 
            "Urban Exploration", "War", "Wedding", "Wildlife"
        };


        public IEnumerable<string> PhotographyGenres
        {
            get
            {
                return from p
                       in this.photographyGenres
                       orderby p
                       select p;
            }
        }

        public void OnGet()
        {
            ViewData["Title"] = "Ofar Photography - Photography Genres";

        }
    }
}
