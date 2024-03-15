namespace SurveyPlatform.Application.Contracts.HelpModels;

public abstract class QuestionRequest(
    int questionId,
    string title,
    string description,
    int typeId,
    IReadOnlyCollection<string> answers)
{
    public int QuestionId { get; } = questionId;

    public string Title { get; } = title;

    public string Description { get; } = description;

    public int TypeId { get; } = typeId;

    public IReadOnlyCollection<string> Answers { get; } = answers;
}