using SurveyPlatform.Application.Contracts.HelpModels;

namespace SurveyPlatform.Application.Contracts.Models;
public abstract class EditSurveyRequest(
    int surveyId,
    int statusId,
    string title,
    string description,
    IList<QuestionRequest> questions) : AddSurveyRequest(statusId, title, description, questions)
{
    public int SurveyId { get; } = surveyId;
}