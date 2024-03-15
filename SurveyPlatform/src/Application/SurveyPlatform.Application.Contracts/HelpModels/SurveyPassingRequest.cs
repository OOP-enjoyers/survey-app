namespace SurveyPlatform.Application.Contracts.HelpModels;

public abstract class SurveyPassingRequest(int surveyId, int userId)
{
    public int SurveyId { get; } = surveyId;

    public int UserId { get; } = userId;
}