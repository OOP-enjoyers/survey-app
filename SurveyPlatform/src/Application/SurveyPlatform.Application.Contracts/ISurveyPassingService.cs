using SurveyPlatform.Application.Contracts.Models;

namespace SurveyPlatform.Application.Contracts;
public interface ISurveyPassingService
{
    // Передача ответов пользователя на опрос
    void PassSurvey(SurveyPassingRequest request);
}