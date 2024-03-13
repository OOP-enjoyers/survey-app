namespace SurveyPlatform.Application.Contracts.Models;

public class SurveyPassingRequest(int surveyId, int userId, List<AnswerRequest> answers)
{
    public int SurveyId { get; set; } = surveyId;

    public int UserId { get; set; } = userId;

    public List<AnswerRequest> Answers { get; set; } = answers;
}