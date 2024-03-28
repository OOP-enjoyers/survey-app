namespace SurveyPlatform.Application.Models.Models;

public class Response
{
    public int Id { get; private set; }

    public string[] Content { get; private set; }

    public int UserId { get; set; }

    public int QuestionId { get; set; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public Response() { }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

    public Response(int id, string[] content, int userId, int questionId)
    {
        Id = id;
        Content = content;
        UserId = userId;
        QuestionId = questionId;
    }
}