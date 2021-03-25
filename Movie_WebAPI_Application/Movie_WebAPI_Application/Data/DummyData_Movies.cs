using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movie_WebAPI_Application.Models;

namespace Movie_WebAPI_Application.Data
{
    public class DummyData_Movies
    {
        public static void Initialize(IApplicationBuilder app)
        {
            // figure out what this does
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                // connects database to the correct context db
                var context = serviceScope.ServiceProvider.GetService<MoviesDbContext>();
                context.Database.EnsureCreated();

                // if movies exist
                if (context.Movies != null && context.Movies.Any())
                    return;

                var movies = DummyData_Movies.GetMovies().ToArray();
                context.Movies.AddRange(movies);
                context.SaveChanges();
            }
        }

        public static List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie
                {
                    //MovieId= 0,
                    Title= "Harry Potter",
                    ReleaseYear= "2001"
                },
                new Movie
                {
                    //MovieId= 1,
                    Title= "Lord of the Rings",
                    ReleaseYear= "2001"
                },
                new Movie
                {
                    //MovieId= 2,
                    Title= "Avengers",
                    ReleaseYear= "2014"
                }
            };
            return movies;
        }
    }
}
