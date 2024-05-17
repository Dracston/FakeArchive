using FakeArchive.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace FaveArchive.Data
{
    public class MainFakeArchiveContext : DbContext
    {
        public MainFakeArchiveContext(DbContextOptions<MainFakeArchiveContext> options) : base(options)
        {
        }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Studio> Studios { get; set; }
