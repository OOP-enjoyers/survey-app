using SurveyPlatform.Application.Abstractions.Persistence.Repositories;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Services;

public class SurveyPassingService(IQuestionRepository questionRepository, IResponseRepository responseRepository) : ISurveyPassingService
{
    public int AddSurveyPassing(int surveyId, int userId, IReadOnlyCollection<IReadOnlyCollection<string>> responses)
    {
        IReadOnlyCollection<Question> questions = questionRepository.GetQuestions(surveyId);
        int i = 0;
        foreach (IReadOnlyCollection<string> response in responses)
        {
            responseRepository.AddResponse(new Response(0, response, userId, questions.ElementAt(i).Id));
            i++;
        }

        return surveyId;
    }

    public IReadOnlyCollection<IReadOnlyCollection<Response>> GetSurveyPassing(int surveyId, int userId)
    {
        // Список вопросов в данном опросе
        var questions = (List<Question>)questionRepository.GetQuestions(surveyId);

        var userResponses = new List<List<Response>>();

        foreach (Question question in questions)
        {
            var questionResponses = (List<Response>)responseRepository.GetResponses(question.Id, userId);
            userResponses.Add(questionResponses);
        }

        return userResponses;
    }
}