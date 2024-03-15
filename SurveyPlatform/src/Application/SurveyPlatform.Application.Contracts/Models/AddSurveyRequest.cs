using SurveyPlatform.Application.Contracts.HelpModels;
using System.Collections.ObjectModel;

namespace SurveyPlatform.Application.Contracts.Models;

public abstract class AddSurveyRequest(int statusId, string title, string description, IList<QuestionRequest> questions)
{
    public int StatusId { get; } = statusId;

    public string Title { get; } = title;

    public string Description { get; } = description;

    public IReadOnlyCollection<QuestionRequest> Questions { get; } = new ReadOnlyCollection<QuestionRequest>(questions);
}