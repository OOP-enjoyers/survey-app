using System.Collections.ObjectModel;

namespace SurveyPlatform.Application.Contracts.Models;

public class AnswerRequest(IList<string> content)
{
     public IReadOnlyCollection<string> Content { get; set; } = new ReadOnlyCollection<string>(content);
}