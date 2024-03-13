namespace SurveyPlatform.Application.Models;

public class QuestionAnswer(
    int id,
    string content,
    int userId,
    int questionAnswerIds)
{
    public int Id { get; private set; } = id;

    public string Content { get; private set; } = content;

    private int UserId { get; set; } = userId;

    private int QuestionAnswerIds { get; set; } = questionAnswerIds;
}