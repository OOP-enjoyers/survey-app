namespace SurveyPlatform.Infrastructure.Persistence.Models;

public class QuestionModel
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public bool IsNecessary { get; set; }

    public string[] Answers { get; set; }

    public int SurveyId { get; set; }

    public int QuestionTypeId { get; set; }

    public QuestionModel(int id, string title, string description, bool isNecessary, string[] answers, int surveyId, int questionTypeId)
    {
        Id = id;
        Title = title;
        Description = description;
        IsNecessary = isNecessary;
        Answers = answers;
        SurveyId = surveyId;
        QuestionTypeId = questionTypeId;
    }
}