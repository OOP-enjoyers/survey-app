namespace SurveyPlatform.Application.Contracts;

using SurveyPlatform.Application.Contracts.Models;

public interface ISurveyPassingService
{
    // Передача ответов пользователя на опрос
    void PassSurvey(SurveyPassingRequest request);
}