using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace FilmCollection.Models
{
    public class databaseContext : DbContext
    {
        public databaseContext (DbContextOptions<databaseContext> options) : base (options)
        {

        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories{ get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId=1,CategoryName="Adventure"},
                new Category { CategoryId = 2, CategoryName = "Action" },
                new Category { CategoryId = 3, CategoryName = "Romance" },
                new Category { CategoryId = 4, CategoryName = "Comedy" },
                new Category { CategoryId = 5, CategoryName = "Horror" },
                new Category { CategoryId = 6, CategoryName = "Thriller" },
                new Category { CategoryId = 7, CategoryName = "Mystery" },
                new Category { CategoryId = 8, CategoryName = "Drama" },
                new Category { CategoryId = 9, CategoryName = "Fantasy" }
            );

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    FilmId = 1,
                    FilmTitle = "Indiana Jones and the Raiders of the Lost Ark",
                    FilmYear = 1981,
                    CategoryId = 1,//"Action/Adventure",
                    FilmRating = "PG",
                    FilmDirector = "George Lucas",
                    Edited = false,
                    LentTo ="",
                    Notes=""
                },

                new ApplicationResponse
                {
                    FilmId = 2,
                    FilmTitle = "Pirates of the Caribbean: The Curse of the Black Pearl",
                    FilmYear = 2003,
                    CategoryId = 1, //"Action/Adventure",
                    FilmRating = "PG-13",
                    FilmDirector = "Gore Verbinski",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },

                new ApplicationResponse
                {
                    FilmId = 3,
                    FilmTitle = "The Count of Monte Cristo",
                    FilmYear = 2002,
                    CategoryId = 2, //"Adventure/Romance",
                    FilmRating = "PG-13",
                    FilmDirector = "Kevin Reynolds",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            ); 
        }
    }
}
