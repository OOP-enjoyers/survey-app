namespace SurveyPlatform.Application.Contracts.Models;

public class AnswerGetRequest(
    int questionId,
    IList<string> content): AnswerRequest(content)
{
    public int QuestionId { get; } = questionId;
}