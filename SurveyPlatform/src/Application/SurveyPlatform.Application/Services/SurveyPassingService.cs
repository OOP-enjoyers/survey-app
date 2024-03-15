using SurveyPlatform.Application.Contracts;
using SurveyPlatform.Application.Contracts.HelpModels;
using SurveyPlatform.Application.Contracts.Models;
using SurveyPlatform.Application.Contracts.Repositories;

namespace SurveyPlatform.Application.Services;

public class SurveyPassingService(IResponseRepository responseRepository) : ISurveyPassingService
{
    public void AddSurveyPassing(AddSurveyPassingRequest request)
    {
        int userId = request.UserId;

        foreach (AnswerRequest response in request.Answers)
        {
            int questionId = response.QuestionId;
            IReadOnlyCollection<string> content = response.Content;

            responseRepository.Add(userId, questionId, content);
        }
    }

    public void GetSurveyPassing(SurveyPassingRequest request)
    {
        // TODO: сделать
    }
}