using Microsoft.EntityFrameworkCore;
using TizzelMovies.Razor.Data;

namespace TizzelMovies.Razor.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new TizzelMoviesRazorContext(
                serviceProvider.GetRequiredService<DbContextOptions<TizzelMoviesRazorContext>>());
            if(context == null || context.Movie == null)
            {
                throw new ArgumentNullException("Null TizzelMoviesRazorContext");
            }
            // Look for any movies.
            //if (context.Movie.Any())
            //{
            //    return;   // DB has been seeded
            //}
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-7-16"),
                    Genre = "Science Fiction",
                    Price = 9.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-3-24"),
                    Genre = "Crime",
                    Price = 12.99M,
                    Rating = "G"
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Action",
                    Price = 14.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "When Harry met Sally",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Romantic Comedy",
                    Price = 14.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Prince of Persia: Sands of Time",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Classic",
                    Price = 1.94M,
                    Rating = "M"
                },
                new Movie
                {
                    Title = "Pirates of the Carribean",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Adventure",
                    Price = 9.4M,
                    Rating = "PG"
                }

            );
            context.SaveChanges();
        }
    }
}
