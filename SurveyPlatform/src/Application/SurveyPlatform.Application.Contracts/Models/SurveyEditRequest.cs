namespace SurveyPlatform.Application.Contracts.Models;

public class SurveyEditRequest(
    int surveyId,
    int statusId,
    string title,
    string description,
    List<QuestionRequest> questions)
{
    public int SurveyId { get; set; } = surveyId;

    public int StatusId { get; set; } = statusId;

    public string Title { get; set; } = title;

    public string Description { get; set; } = description;

    public List<QuestionRequest> Questions { get; set; } = questions;
}