using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SurveyPlatform.Application.Abstractions.Persistence;
using SurveyPlatform.Application.Abstractions.Persistence.Repositories;
using SurveyPlatform.Infrastructure.Persistence.Contexts;
using SurveyPlatform.Infrastructure.Persistence.Repositories;

namespace SurveyPlatform.Infrastructure.Persistence.Extensions;

public static class RepositoryCollectionExtensions
{
    public static IServiceCollection AddInfrastructurePersistence(this IServiceCollection collection, IConfiguration configuration)
    {
        AddConnection(collection, configuration);

        collection.AddScoped<IPersistenceContext, PersistenceContext>();
        collection.AddScoped<IUserRepository, UserRepository>();
        collection.AddScoped<ISurveyRepository, SurveyRepository>();
        collection.AddScoped<IResponseRepository, ResponseRepository>();
        collection.AddScoped<IQuestionRepository, IQuestionRepository>();
        collection.AddScoped<DbContext, ApplicationDbContext>();

        return collection;
    }

    public static IServiceCollection AddConnection(this IServiceCollection collection, IConfiguration configuration)
    {
        collection.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetSection("Infrastructure:Persistence:Postgres:ConnectionString").Value));
        return collection;
    }
}