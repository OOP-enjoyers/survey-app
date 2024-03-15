using SurveyPlatform.Application.Contracts.Models;
using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Contracts.Repositories;

public interface ISurveyRepository
{
    // Добавление опроса
    int AddSurvey(AddSurveyRequest request);

    // Получение опроса по id
    Survey GetSurvey(int surveyId);

    // Изменение опроса
    void EditSurvey(EditSurveyRequest request);

    // Удаление опроса
    void RemoveSurvey(int surveyId);
}