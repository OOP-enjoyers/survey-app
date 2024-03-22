namespace SurveyPlatform.Application.Models.DTO;
public class QuestionDto
{
    public string Title { get; set; }

    public string Description { get; set; }

    public bool IsNecessary { get; set; }

    public string[] Answers { get; set; }

    public int SurveyId { get; set; }

    public int QuestionTypeId { get; set; }

    public QuestionDto(string title, string description, bool isNecessary, string[] answers, int surveyId, int questionTypeId)
    {
        Title = title;
        Description = description;
        IsNecessary = isNecessary;
        Answers = answers;
        SurveyId = surveyId;
        QuestionTypeId = questionTypeId;
    }
}
