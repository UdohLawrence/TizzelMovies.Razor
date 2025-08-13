﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly TizzelMovies.Razor.Data.TizzelMoviesRazorContext _context;

        public DetailsModel(TizzelMovies.Razor.Data.TizzelMoviesRazorContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (movie is not null)
            {
                Movie = movie;

                return Page();
            }

            return NotFound();
        }
    }
}
