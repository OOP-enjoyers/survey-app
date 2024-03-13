namespace SurveyPlatform.Application.Models;

public class QuestionAnswer(int id, string content)
{
    public int Id { get; private set; } = id;

    public string Content { get; private set; } = content;

    private int UserId { get; set; }

    private int QuestionAnswerIds { get; set; }
}