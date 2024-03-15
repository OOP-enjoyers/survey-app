#pragma warning disable IDE0051

using System.Collections.ObjectModel;

namespace SurveyPlatform.Application.Models;

public class Response(
    int id,
    ReadOnlyCollection<string> content,
    int userId,
    int questionId)
{
    public int Id { get; private set; } = id;

    public ReadOnlyCollection<string> Content { get; private set; } = content;

    private int UserId { get; set; } = userId;

    private int QuestionId { get; set; } = questionId;
}

#pragma warning restore IDE0051