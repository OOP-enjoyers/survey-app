using SurveyPlatform.Application.Contracts;
using SurveyPlatform.Application.Models;
using SurveyPlatform.Infrastructure.Persistence.Repositories;

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
        return responseRepository.GetResponses(surveyId, userId);
    }
}