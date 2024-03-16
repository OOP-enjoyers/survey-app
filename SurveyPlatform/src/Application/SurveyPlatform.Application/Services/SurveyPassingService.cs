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
        return responseRepository.GetResponses(surveyId, userId);
    }
}