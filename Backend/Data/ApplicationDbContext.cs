using Escape.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Escape.Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        { }

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
            });

            modelBuilder.Entity<Team>(team =>
            {
                team.HasMany(t => t.UserTeams)
                    .WithOne(u => u.Team);
            });

        }
    }

}