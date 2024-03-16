namespace SurveyPlatform.Infrastructure.Persistence.Models;

public class QuestionModel(
    int id,
    string title,
    string description,
    bool isNecessary,
    IReadOnlyCollection<string> answers,
    int surveyId,
    int questionTypeId)
{
    public int Id { get; set; } = id;

    public string Title { get; set; } = title;

    public string Description { get; set; } = description;

    public bool IsNecessary { get; set; } = isNecessary;

    public IReadOnlyCollection<string> Answers { get; set; } = answers;

    public int SurveyId { get; set; } = surveyId;

    public int QuestionTypeId { get; set; } = questionTypeId;
}