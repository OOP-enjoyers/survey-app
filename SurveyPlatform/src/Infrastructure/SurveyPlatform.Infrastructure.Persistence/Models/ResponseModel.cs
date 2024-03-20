namespace SurveyPlatform.Infrastructure.Persistence.Models;

public class ResponseModel(
    int id,
    string[] content,
    int userId,
    int questionId)
{
    public int Id { get; set; } = id;

    public string[] Content { get; set; } = content;

    public int UserId { get; set; } = userId;

    public int QuestionId { get; set; } = questionId;
}