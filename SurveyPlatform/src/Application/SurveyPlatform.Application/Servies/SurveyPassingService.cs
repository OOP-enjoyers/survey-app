using SurveyPlatform.Application.Contracts;
using SurveyPlatform.Application.Contracts.Models;

namespace SurveyPlatform.Application;

public class SurveyPassingService(): ISurveyPassingService
{
    private readonly IResponseRepository _responseRepository;

    public SurveyPassingService(IResponseRepository responseRepository)
    {
        _responseRepository = responseRepository;
    }

    public void PassSurvey(SurveyPassingRequest request)
    {
        int userId = request.UserId;

        foreach (AnswerRequest responce in request.Answers)
        {
            int questionId = responce.QuestionId;
            IReadOnlyCollection<string> content = responce.Content;

            _responseRepository.Add(userId, questionId, content);
        }
    }
}