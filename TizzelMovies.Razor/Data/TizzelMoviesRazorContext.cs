using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TizzelMovies.Razor.Models;

namespace TizzelMovies.Razor.Data
{
    public class TizzelMoviesRazorContext : DbContext
    {
        public TizzelMoviesRazorContext (DbContextOptions<TizzelMoviesRazorContext> options)
            : base(options)
        {
        }

        public DbSet<TizzelMovies.Razor.Models.Movie> Movie { get; set; } = default!;
    }
}
