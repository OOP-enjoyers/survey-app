using SurveyPlatform.Application.Contracts.Models;
using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Contracts;

public interface ISurveyService
{
    // Добавление опроса
    void AddSurvey(AddSurveyRequest request);

    // Получение опроса по id
    Survey GetSurvey(int surveyId);

    // Изменение опроса
    void EditSurvey(EditSurveyRequest request);

    // Удаление опроса
    void RemoveSurvey(int surveyId);
}