#pragma warning disable IDE0051

namespace SurveyPlatform.Application.Models;

public class Response(
    int id,
    IReadOnlyCollection<string> content,
    int userId,
    int questionId)
{
    public int Id { get; private set; } = id;

    public IReadOnlyCollection<string> Content { get; private set; } = content;

    public int UserId { get; set; } = userId;

    public int QuestionId { get; set; } = questionId;
}

#pragma warning restore IDE0051