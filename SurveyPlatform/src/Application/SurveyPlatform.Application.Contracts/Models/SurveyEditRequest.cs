namespace SurveyPlatform.Application.Contracts.Models;
public abstract class SurveyEditRequest(
    int surveyId,
    int statusId,
    string title,
    string description,
    IList<QuestionRequest> questions) : SurveyCreationRequest(statusId, title, description, questions)
{
    public int SurveyId { get; } = surveyId;
}