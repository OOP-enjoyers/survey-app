namespace SurveyPlatform.Application.Models.Models;

public class Response(
    int id,
    string[] content,
    int userId,
    int questionId)
{
    public int Id { get; private set; } = id;

    public string[] Content { get; private set; } = content;

    public int UserId { get; set; } = userId;

    public int QuestionId { get; set; } = questionId;
}