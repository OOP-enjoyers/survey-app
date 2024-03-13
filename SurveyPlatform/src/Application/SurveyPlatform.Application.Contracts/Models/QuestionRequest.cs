using System.Collections.ObjectModel;

namespace SurveyPlatform.Application.Contracts.Models;
public abstract class QuestionRequest(string title, string description, int typeId, IList<AnswerRequest> answers)
{
    public string Title { get; } = title;

    public string Description { get; } = description;

    public int TypeId { get; } = typeId;

    public IReadOnlyCollection<AnswerRequest> Answers { get; } = new ReadOnlyCollection<AnswerRequest>(answers);
}