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
        public DbSet<FavoriteTeams> FavoriteTeams { get; set; }
        public DbSet<TeamStats> TeamStats { get; set; }
        public DbSet<PlayerStats> PlayerStats { get; set; }
        public DbSet<Bracket> Brackets { get; set; }



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
            modelBuilder.Entity<Player>()
                .ToTable("Players").HasKey(p => new { p.Id });
            modelBuilder.Entity<TeamStats>()
                .ToTable("TeamStats").HasNoKey();
            modelBuilder.Entity<PlayerStats>()
                .ToTable("PlayerStats").HasKey(ps => new {ps.PlayerId});
            modelBuilder.Entity<Bracket>()
                .ToTable("Brackets").HasKey(b => new { b.UserId});
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
