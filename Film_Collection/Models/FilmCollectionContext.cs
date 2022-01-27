using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Film_Collection.Models
{
    public class FilmCollectionContext : DbContext
    {
        // Constructor
        public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options) : base (options)
        {
            // Leaving blank for now
        }

        // I think this sets the table name for the database
        public DbSet<MoviesModel> Films { get; set; }

        // Seeding the database with my three "favorite" movies that all happened to be from 2010 (seriously, I don't know how those were the three that came to mind)
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MoviesModel>().HasData(
                new MoviesModel
                {
                    FormId = 1,
                    Category = "Horror",
                    Title = "Insidious",
                    Year = 2010,
                    Director = "James Wan",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "Aaron",
                },
                new MoviesModel
                {
                    FormId = 2,
                    Category = "Sci-fi/Mystery/Thriller",
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    Notes = "Dreams"
                },
                new MoviesModel
                {
                    FormId = 3,
                    Category = "Animated",
                    Title = "Tangled",
                    Year = 2010,
                    Director = "Stephen Sandoval",
                    Rating = "PG",
                    Edited = false
                }
            );
        }
    }
}