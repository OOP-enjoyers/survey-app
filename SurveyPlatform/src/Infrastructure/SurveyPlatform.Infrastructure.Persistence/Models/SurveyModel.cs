namespace SurveyPlatform.Infrastructure.Persistence.Models;

public class SurveyModel(
    int id,
    string title,
    string description,
    int surveyStatusId)
{
    public int Id { get; set; } = id;

    public string Title { get; set; } = title;

    public string Description { get; set; } = description;

    public int SurveyStatus { get; set; } = surveyStatusId;
}