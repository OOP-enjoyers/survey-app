using Microsoft.EntityFrameworkCore;
using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Infrastructure.Persistence.Contexts;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    required public DbSet<User> Users { get; set; }

    required public DbSet<Question> Questions { get; set; }

    required public DbSet<Survey> Surveys { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=ep-green-king-a2za032r.eu-central-1.aws.neon.tech/team8;Port=5432;Database=usersdb2;Username=team8_owner;Password=SJkgF5RT7UQL");
    }
}