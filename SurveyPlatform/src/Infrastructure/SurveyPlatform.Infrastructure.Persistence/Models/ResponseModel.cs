namespace SurveyPlatform.Infrastructure.Persistence.Models;

public class ResponseModel(
    int id,
    IReadOnlyCollection<string> content,
    int userId,
    int questionId)
{
    public int Id { get; set; } = id;

    public IReadOnlyCollection<string> Content { get; set; } = content;

    public int UserId { get; set; } = userId;

    public int QuestionId { get; set; } = questionId;
}