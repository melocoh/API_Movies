using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movie_WebAPI_Application.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Movie_WebAPI_Application.Data
{
    public class MoviesDbContext : IdentityDbContext
    {

        public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
            : base(options)
        {

        }

        // ??
        //public MoviesDbContext(DbContextOptions options) : base(options) { }

        // gets and sets components of Movies model
        public DbSet<Movie> Movies { get; set; }

        // turns entity model into table
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Movie>().ToTable("Movie");
        //}
    }
}
