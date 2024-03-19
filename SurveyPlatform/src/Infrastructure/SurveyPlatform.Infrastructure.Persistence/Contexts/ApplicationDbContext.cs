#pragma warning disable SA1206

using Microsoft.EntityFrameworkCore;
using SurveyPlatform.Infrastructure.Persistence.Models;

namespace SurveyPlatform.Infrastructure.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public required DbSet<UserModel> Users { get; set; }

    public required DbSet<SurveyModel> Surveys { get; set; }

    public required DbSet<ResponseModel> Responses { get; set; }

    public required DbSet<QuestionModel> Questions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}

#pragma warning restore SA1206