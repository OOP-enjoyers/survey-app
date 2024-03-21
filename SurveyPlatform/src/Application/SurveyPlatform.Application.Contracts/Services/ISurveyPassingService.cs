using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Contracts.Services;

public interface ISurveyPassingService
{
    // Добавление ответов пользователя на опрос
    int AddSurveyPassing(int surveyId, int userId, string[][] responses);

    // Получение всех ответов пользователя на опрос
    IReadOnlyCollection<IReadOnlyCollection<Response>> GetSurveyPassing(int surveyId, int userId);
}