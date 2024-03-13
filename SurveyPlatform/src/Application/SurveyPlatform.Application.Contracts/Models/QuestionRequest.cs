namespace SurveyPlatform.Application.Contracts.Models;

public class QuestionRequest(string title, string description, int typeId, List<AnswerRequest> answers)
{
    public string Title { get; set; } = title;

    public string Description { get; set; } = description;

    public int TypeId { get; set; } = typeId;

    public List<AnswerRequest> Answers { get; set; } = answers;
}