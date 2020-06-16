using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieListRazor.Model;

namespace MovieListRazor.Pages.MovieList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Movie Movie { get; set; }

        public void OnGet()
        {

        }

        public async Task <IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Movie.AddAsync(Movie);
                await _db.SaveChangesAsync();
                return RedirectToPage("index");
            }
            else
            {
                return Page();
            }
        }
    }
}