using SurveyPlatform.Application.Contracts.HelpModels;
using SurveyPlatform.Application.Contracts.Models;

namespace SurveyPlatform.Application.Contracts;

public interface ISurveyPassingService
{
    // Добавление ответов пользователя на опрос
    void AddSurveyPassing(AddSurveyPassingRequest request);

    // Получение ответов пользователя на опрос
    void GetSurveyPassing(SurveyPassingRequest request);
}