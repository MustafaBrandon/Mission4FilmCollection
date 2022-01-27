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

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    FilmId = 1,
                    FilmTitle = "Indiana Jones and the Raiders of the Lost Ark",
                    FilmYear = 1981,
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
                    Category = "Adventure/Romance",
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
