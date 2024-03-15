using SurveyPlatform.Application.Contracts;
using SurveyPlatform.Application.Contracts.HelpModels;
using SurveyPlatform.Application.Contracts.Models;
using SurveyPlatform.Application.Contracts.Repositories;
using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Services;

public class SurveyService(ISurveyRepository surveyRepository, IQuestionRepository questionRepository) : ISurveyService
{
    // Добавление опроса
    public void AddSurvey(AddSurveyRequest request)
    {
        int surveyId = surveyRepository.AddSurvey(request);
        foreach (QuestionRequest question in request.Questions)
        {
            questionRepository.AddQuestion(question.Title, question.Description, question.Answers, question.TypeId, surveyId);
        }
    }

    // Получение опроса по id
    public Survey GetSurvey(int surveyId)
    {
        return surveyRepository.GetSurvey(surveyId);
    }

    // Изменение опроса
    public void EditSurvey(EditSurveyRequest request)
    {
        // TODO: Реализовать
    }

    // Удаление опроса
    public void RemoveSurvey(int surveyId)
    {
        surveyRepository.RemoveSurvey(surveyId);
    }
}