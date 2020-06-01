using Microsoft.EntityFrameworkCore;
using Project01.Models;
using System; 

namespace Project01.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movie { get; set; }
    }
}
