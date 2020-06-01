using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project01.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var iContext = new MovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieContext>>()))
            {
                if (iContext.Movie.Any())
                {
                    return;
                }

                iContext.Movie.AddRange(
                    new Movie
                    {
                        IdMovie = 1,
                        Title = "Baywatch",
                        ReleaseDate = DateTime.Parse("2017-5-12"),
                        Genre = "Comedy/Action",
                        Price = 15.5M
                    },
                    new Movie
                    {
                        IdMovie = 2,
                        Title = "Central Intelligence",
                        ReleaseDate = DateTime.Parse("2016-7-1"),
                        Genre = "Comedy/Action",
                        Price = 10.33M
                    },
                    new Movie
                    {
                        IdMovie = 3,
                        Title = "We're the Millers",
                        ReleaseDate = DateTime.Parse("2013-8-15"),
                        Genre = "Comedy/Crime",
                        Price = 8.22M
                    },
                    new Movie
                    {
                        IdMovie = 4,
                        Title = "Southpaw",
                        ReleaseDate = DateTime.Parse("2015-6-15"),
                        Genre = "Sport/Drama",
                        Price = 12.83M
                    }
                    );
            }
        }
    }
}
