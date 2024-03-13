namespace SurveyPlatform.Application.Contracts;

using SurveyPlatform.Application.Contracts.Models;

public interface ISurveyService
{
    // Создание нового опроса
    void CreateSurvey(SurveyCreationRequest request);

    // Изменение существующего опроса
    void EditSurvey(SurveyEditRequest request);

    // Удаление опроса
    void RemoveSurvey(int surveyId);
}