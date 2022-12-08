using Liftoff_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Liftoff_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamPlayer> TeamPlayers { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<FavoriteTeams> FavoriteTeams { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<TeamPlayer>()
                .ToTable("Team_Player").HasKey(tp => new { tp.PlayerId, tp.TeamId });
            modelBuilder.Entity<FavoriteTeams>()
                .ToTable("Favorite_Teams").HasKey(f => new { f.UserId, f.TeamId });
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
