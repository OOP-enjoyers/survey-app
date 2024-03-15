using System.Collections.ObjectModel;

namespace SurveyPlatform.Application.Contracts.HelpModels;

public abstract class AnswerRequest(int questionId, IList<string> content)
{
     public int QuestionId { get; } = questionId;

     public IReadOnlyCollection<string> Content { get; set; } = new ReadOnlyCollection<string>(content);
}