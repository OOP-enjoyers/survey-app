namespace SurveyPlatform.Application.Contracts.Models;

public abstract class QuestionRequest(string title, string description, int typeId, AnswerRequest answers)
{
    public string Title { get; } = title;

    public string Description { get; } = description;

    public int TypeId { get; } = typeId;

    public AnswerRequest Answers { get; } = answers;
}