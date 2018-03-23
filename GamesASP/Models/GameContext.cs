using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GamesASP.Models
{
    public class GameContext : DbContext
    {

        public GameContext() : base("GameContext")
        {
        }  
        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Dev { get; set; }
        public DbSet<Genres> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasMany(c => c.Genres)
                .WithMany(s => s.Games)
                .Map(t => t.MapLeftKey("GameId")
                .MapRightKey("GenresId")
                .ToTable("GameGenres"));
        }

    }


}