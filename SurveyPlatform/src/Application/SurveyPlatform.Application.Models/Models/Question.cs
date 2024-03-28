using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Models.Models;

public class Question
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public bool IsNecessary { get; set; }

    public string[] Answers { get; set; }

    public int SurveyId { get; set; }

    public QuestionType QuestionType { get; set; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public Question() { }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

    public Question(int id, string title, string description, bool isNecessary, string[] answers, int surveyId, QuestionType questionType)
    {
        Id = id;
        Title = title;
        Description = description;
        IsNecessary = isNecessary;
        Answers = answers;
        SurveyId = surveyId;
        QuestionType = questionType;
    }
}