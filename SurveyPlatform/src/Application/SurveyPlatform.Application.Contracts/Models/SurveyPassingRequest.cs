using System.Collections.ObjectModel;

namespace SurveyPlatform.Application.Contracts.Models;
public abstract class SurveyPassingRequest(int surveyId, int userId, IList<AnswerRequest> answers)
{
    public int SurveyId { get; } = surveyId;

    public int UserId { get; } = userId;

    public IReadOnlyCollection<AnswerRequest> Answers { get; } = new ReadOnlyCollection<AnswerRequest>(answers);
}