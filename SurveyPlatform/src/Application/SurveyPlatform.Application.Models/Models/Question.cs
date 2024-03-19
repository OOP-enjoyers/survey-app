using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Models.Models;

public class Question(
    int id,
    string title,
    string description,
    bool isNecessary,
    IReadOnlyCollection<string> answers,
    QuestionType questionType)
{
    public int Id { get; set; } = id;

    public string Title { get; set; } = title;

    public string Description { get; set; } = description;

    public bool IsNecessary { get; set; } = isNecessary;

    public IReadOnlyCollection<string> Answers { get; set; } = answers;

    public QuestionType QuestionType { get; set; } = questionType;
}