using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Models.Models;

public class Survey
{
    public int Id { get; private set; }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public SurveyStatus SurveyStatus { get; set; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public Survey()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    { }

    public Survey(int id, string title, string description, SurveyStatus surveyStatus)
    {
        Id = id;
        Title = title;
        Description = description;
        SurveyStatus = surveyStatus;
    }

    public IReadOnlyCollection<Question>? Questions { get; set; }
}