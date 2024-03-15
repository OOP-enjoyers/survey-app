using SurveyPlatform.Application.Contracts;
using SurveyPlatform.Application.Contracts.Models;
using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Services;

public class SurveyService(): ISurveyService
{
    private readonly ISurveyRepository _surveyRepository;
    private readonly IQuestionRepository _questionRepository;

    public SurveyService(ISurveyRepository surveyRepository, IQuestionRepository questionRepository)
    {
        _surveyRepository = surveyRepository;
        _questionRepository = questionRepository;
    }
    
    // Создание нового опроса
    public void CreateSurvey(SurveyCreationRequest request)
    {
        _surveyRepository.Add(request.StatusId, request.Title, request.Description);

        foreach (QuestionRequest question in request.Questions)
        {
            int questionId = responce.QuestionId;
            IReadOnlyCollection<string> content = responce.Content;

            _responseRepository.Add(userId, questionId, content);
        }
    }

    // Изменение существующего опроса
    public void EditSurvey(SurveyEditRequest request)
    {
        //TODO: Реализовать
    }

    public void RemoveSurvey(int surveyId)
    {
        _surveyRepository.Remove(surveyId);
    }

    // Получение опроса по id
    public void GetSurvey(int surveyId)
    {
        Survey survey = _surveyRepository.GetById(surveyId);
        IReadOnlyCollection<Question> questions = _questionRepository.GetBySurveyId(surveyId);

        //TODO: преобразовать к классу запроса для GetSurvey
    }
}