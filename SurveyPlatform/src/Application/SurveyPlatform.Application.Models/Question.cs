#pragma warning disable IDE0051
using SurveyPlatform.Application.Models.Enums;
using System.Collections.ObjectModel;

namespace SurveyPlatform.Application.Models;

public class Question(
    int id,
    string title,
    string description,
    bool isNecessary,
    ReadOnlyCollection<string> answers,
    int surveyId,
    QuestionType questionType)
{
    public int Id { get; private set; } = id;

    public string Title { get; private set; } = title;

    public string Description { get; private set; } = description;

    public bool IsNecessary { get; private set; } = isNecessary;

    public ReadOnlyCollection<string> Answers { get; private set; } = answers;

    private int SurveyId { get; set; } = surveyId;

    private QuestionType QuestionType { get; set; } = questionType;
}
#pragma warning restore IDE0051