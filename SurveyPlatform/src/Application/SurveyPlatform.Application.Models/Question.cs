namespace SurveyPlatform.Application.Models;

public class Question(
    int id,
    string title,
    string description,
    bool isNecessary,
    int surveyId,
    QuestionType questionType)
{
    public int Id { get; private set; } = id;

    public string Title { get; private set; } = title;

    public string Description { get; private set; } = description;

    public bool IsNecessary { get; private set; } = isNecessary;

    private int SurveyId { get; set; } = surveyId;

    private QuestionType QuestionType { get; set; } = questionType;
}