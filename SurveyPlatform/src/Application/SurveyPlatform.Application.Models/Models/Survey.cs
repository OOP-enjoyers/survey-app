using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Models.Models;

public class Survey(
    int id,
    string title,
    string description,
    SurveyStatus surveyStatus)
{
    public int Id { get; private set; } = id;

    public string Title { get; private set; } = title;

    public string Description { get; private set; } = description;

    public SurveyStatus SurveyStatus { get; set; } = surveyStatus;

    public IReadOnlyCollection<Question>? Questions { get; set; }
}