using SurveyPlatform.Application.Contracts.HelpModels;
using System.Collections.ObjectModel;

namespace SurveyPlatform.Application.Contracts.Models;

public abstract class AddSurveyPassingRequest(int surveyId, int userId, IList<AnswerRequest> answers) : SurveyPassingRequest(surveyId, userId)
{
    public IReadOnlyCollection<AnswerRequest> Answers { get; } = new ReadOnlyCollection<AnswerRequest>(answers);
}