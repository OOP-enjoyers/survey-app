namespace SurveyPlatform.Application.Models.Models;

public class Response(
    int id,
    IReadOnlyCollection<string> content,
    User user,
    Question question)
{
    public int Id { get; private set; } = id;

    public IReadOnlyCollection<string> Content { get; private set; } = content;

    public User User { get; set; } = user;

    public Question Question { get; set; } = question;
}