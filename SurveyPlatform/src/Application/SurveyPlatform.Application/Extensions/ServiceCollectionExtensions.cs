using Microsoft.Extensions.DependencyInjection;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Services;

namespace SurveyPlatform.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IUserService, UserService>();
        collection.AddScoped<ISurveyService, SurveyService>();
        collection.AddScoped<ISurveyPassingService, SurveyPassingService>();

        return collection;
    }
}