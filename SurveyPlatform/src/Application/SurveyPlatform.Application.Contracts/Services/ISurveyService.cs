using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Contracts.Services;

public interface ISurveyService
{
    // Добавление опроса
    int AddSurvey(Survey survey);

    // Получение опроса по id
    Survey GetSurvey(int surveyId);

    // Изменение опроса
    int EditSurvey(Survey survey);

    // Удаление опроса
    int RemoveSurvey(int surveyId);
}