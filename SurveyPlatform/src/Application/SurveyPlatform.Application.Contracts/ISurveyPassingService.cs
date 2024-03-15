using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Contracts;

public interface ISurveyPassingService
{
    // Добавление ответов пользователя на опрос
    int AddSurveyPassing(int surveyId, int userId, IReadOnlyCollection<IReadOnlyCollection<string>> responses);

    // Получение ответов пользователя на опрос
    IReadOnlyCollection<IReadOnlyCollection<Response>> GetSurveyPassing(int surveyId, int userId);
}