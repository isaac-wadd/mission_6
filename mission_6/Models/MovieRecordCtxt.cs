
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission_6.Models {

// 'Movie' class to record data
    public class MovieRecordCtxt : DbContext {
        public MovieRecordCtxt(DbContextOptions<MovieRecordCtxt> options) : base(options) { }
        public DbSet<Movie> movie { get; set; }

// this is a way to insert data at the conception of the database
        // protected override void OnModelCreating(ModelBuilder mb) {
        //     mb.Entity<Movie>().HasData(
        //         new Movie {
        //             movieID = 1,
        //             title = "Gladiator",

        //         }
        //     );
        // }
    }
}
