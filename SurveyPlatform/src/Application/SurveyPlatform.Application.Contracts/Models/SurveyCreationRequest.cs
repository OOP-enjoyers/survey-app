namespace SurveyPlatform.Application.Contracts.Models;

public class SurveyCreationRequest(int statusId, string title, string description, List<QuestionRequest> questions)
{
    public int StatusId { get; set; } = statusId;

    public string Title { get; set; } = title;

    public string Description { get; set; } = description;

    public List<QuestionRequest> Questions { get; set; } = questions;
}