using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Contracts.Services;

public interface ISurveyService
{
    // Добавление опроса
    int AddSurvey(Survey survey, IReadOnlyCollection<Question> questions);

    // Получение опроса по id
    (Survey Survey, IReadOnlyCollection<Question> Questions) GetSurvey(int surveyId);

    // Изменение опроса
    int EditSurvey(Survey survey, IReadOnlyCollection<Question> questions);

    // Удаление опроса
    int RemoveSurvey(int surveyId);
}