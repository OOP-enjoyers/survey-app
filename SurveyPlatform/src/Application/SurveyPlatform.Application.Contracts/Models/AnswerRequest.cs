namespace SurveyPlatform.Application.Contracts.Models;

public class AnswerRequest(string content)
{
    public string Content { get; set; } = content;
}