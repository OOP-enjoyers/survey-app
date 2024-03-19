using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Abstractions.Persistence.Repositories;

public interface ISurveyRepository
{
    // Добавление опроса
    Survey AddSurvey(Survey survey);

    // Получение опроса по id
    Survey GetSurvey(int surveyId);

    // Изменение опроса
    Survey EditSurvey(Survey survey);

    // Удаление опроса
    Survey RemoveSurvey(int surveyId);
}