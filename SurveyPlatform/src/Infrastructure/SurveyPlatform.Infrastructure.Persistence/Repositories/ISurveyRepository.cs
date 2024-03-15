using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Infrastructure.Persistence.Repositories;

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