using FakeArchive.Models;
using Microsoft.EntityFrameworkCore;

namespace FakeArchive.Data
{
    

       public class MainFakeArchiveContext : DbContext
        {
            public MainFakeArchiveyContext(DbContextOptions<MainFakeArchiveContext> options)
                : base(options)
            {
            }

            public DbSet<Game> Games { get; set; }
            public DbSet<Movie> Movies { get; set; }
            public DbSet<Show> Shows { get; set; }
            public DbSet<Director> Directors { get; set; }
            public DbSet<Studio> Studios { get; set; }
        }

    
}
