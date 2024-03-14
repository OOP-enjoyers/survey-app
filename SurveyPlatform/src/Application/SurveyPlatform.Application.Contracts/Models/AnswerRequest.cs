using System.Collections.ObjectModel;

namespace SurveyPlatform.Application.Contracts.Models;

public class AnswerRequest(int questionId, IList<string> content)
{
    public int QuestionId { get; }
    public IReadOnlyCollection<string> Content { get; set; } = content;
}