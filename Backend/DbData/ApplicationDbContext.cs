﻿using Escape.Backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Escape.Backend.DbData
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration)
          : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PlayedRoom> PlayedRoom { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomReview> RoomReviews { get; set; }
        public DbSet<Society> Societies { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user =>
            {
                user.HasKey(u => u.UserId);

                user.HasMany(u => u.UserTeams);

                user.HasMany(u => u.Reviews);

                user.HasOne(u => u.Profile)
                    .WithOne(p => p.User);

                user.HasOne(u => u.UserIdentity).WithOne();
            });

            modelBuilder.Entity<Team>(team =>
            {
                team.HasKey(t => t.TeamId);

                team.HasMany(t => t.UserTeams)
                    .WithOne(u => u.Team);
            });

            modelBuilder.Entity<UserProfile>(profile =>
            {
                profile.HasKey(p => new
                {
                    p.UserProfileId,
                    p.UserId
                });
            });

            modelBuilder.Entity<PlayedRoom>(playedRoom =>
            {
                playedRoom.HasKey(p => new
                {
                    p.RoomId,
                    p.TeamId
                });
            });

            modelBuilder.Entity<UserTeam>(userTeam =>
            {
                userTeam.HasKey(p => new
                {
                    p.UserId,
                    p.TeamId
                });
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
    }

}