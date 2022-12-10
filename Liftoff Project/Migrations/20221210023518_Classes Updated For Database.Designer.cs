﻿// <auto-generated />
using System;
using Liftoff_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Liftoff_Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221210023518_Classes Updated For Database")]
    partial class ClassesUpdatedForDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Liftoff_Project.Models.FavoriteTeams", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("TeamId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("Favorite_Teams");
                });

            modelBuilder.Entity("Liftoff_Project.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Citizenship")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Height_meter")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Jersey")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Position")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Team")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TeamId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Weight")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Liftoff_Project.Models.Team", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Fifa_code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Flag")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Groups")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Iso2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name_en")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name_fa")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("_Id")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Liftoff_Project.Models.TeamPlayer", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<string>("TeamId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("PlayerId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("Team_Player");
                });

            modelBuilder.Entity("Liftoff_Project.Models.TeamStats", b =>
                {
                    b.Property<string>("AccurateCrosses")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AccurateLongBalls")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AccuratePasses")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Away_Goal")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Away_Team")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BlockedShots")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CrossPct")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Date_US_Eastern")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EffectiveClearance")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EffectiveTackles")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Fixture")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FoulsCommitted")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Home_Goal")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Home_Team")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Interceptions")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LongballPct")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Offsides")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PassPct")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PenaltyKickGoals")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PenaltyKickShots")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PossessionPct")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RedCards")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Saves")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ShotPct")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ShotsOnTarget")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TacklePct")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TeamName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Time_US_Eastern")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TotalClearance")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TotalCrosses")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TotalLongBalls")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TotalPasses")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TotalShots")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TotalTackles")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UpdateTime")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("WonCorners")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("YellowCards")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.ToTable("TeamStats");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Liftoff_Project.Models.FavoriteTeams", b =>
                {
                    b.HasOne("Liftoff_Project.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Liftoff_Project.Models.TeamPlayer", b =>
                {
                    b.HasOne("Liftoff_Project.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Liftoff_Project.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}