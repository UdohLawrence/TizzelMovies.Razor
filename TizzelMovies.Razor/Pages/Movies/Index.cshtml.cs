using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TizzelMovies.Razor.Data;
using TizzelMovies.Razor.Models;

namespace TizzelMovies.Razor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly TizzelMovies.Razor.Data.TizzelMoviesRazorContext _context;

        public IndexModel(TizzelMovies.Razor.Data.TizzelMoviesRazorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
