using SurveyPlatform.Application.Abstractions.Persistence.Repositories;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Services;

public class SurveyPassingService(IQuestionRepository questionRepository, IResponseRepository responseRepository) : ISurveyPassingService
{
    public int AddSurveyPassing(int surveyId, int userId, string[][] responses)
    {
        IReadOnlyCollection<Question> questions = questionRepository.GetQuestions(surveyId);
        int i = 0;
        foreach (var response in responses)
        {
            responseRepository.AddResponse(new Response(0, response, userId, questions.ElementAt(i).Id));
            i++;
        }

        return surveyId;
    }

    public IReadOnlyCollection<IReadOnlyCollection<Response>> GetSurveyPassing(int surveyId, int userId)
    {
        var questions = (List<Question>)questionRepository.GetQuestions(surveyId);

        var userResponsesByAttempt = new List<List<Response>>();
        var questionResponsesFirst = (List<Response>)responseRepository.GetResponses(questions[0].Id, userId);
        for (int i = 0; i < questionResponsesFirst.Count; i++)
        {
            userResponsesByAttempt.Add(new List<Response>());
        }

        foreach (var question in questions)
        {
            var questionResponses = (List<Response>)responseRepository.GetResponses(question.Id, userId);

            for (int j = 0; j < questionResponses.Count; j++)
            {
                userResponsesByAttempt[j].Add(questionResponses[j]);
            }
        }

        return userResponsesByAttempt;
    }
}