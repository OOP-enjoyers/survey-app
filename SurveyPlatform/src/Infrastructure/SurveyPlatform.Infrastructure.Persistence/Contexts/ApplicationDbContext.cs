using Microsoft.EntityFrameworkCore;
using SurveyPlatform.Application.Models;

#pragma warning disable IDE0161
namespace SurveyPlatform.Infrastructure.Persistence.Contexts
#pragma warning restore IDE0161
{
    public sealed class ApplicationDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }

        public DbSet<Question>? Questions { get; set; }

        public DbSet<Survey>? Surveys { get; set; }

        public DbSet<Response>? Responses { get; set; }

        public ApplicationDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=ep-green-king-a2za032r.eu-central-1.aws.neon.tech/team8;Port=5432;Database=usersdb2;Username=team8_owner;Password=SJkgF5RT7UQL");
        }
    }
}