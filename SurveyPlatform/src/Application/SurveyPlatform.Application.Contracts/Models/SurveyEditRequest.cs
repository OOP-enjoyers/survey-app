﻿using System.Collections.ObjectModel;

namespace SurveyPlatform.Application.Contracts.Models;
public abstract class SurveyEditRequest(
    int surveyId,
    int statusId,
    string title,
    string description,
    IList<QuestionRequest> questions)
{
    public int SurveyId { get; } = surveyId;

    public int StatusId { get; } = statusId;

    public string Title { get; } = title;

    public string Description { get; } = description;

    public IReadOnlyCollection<QuestionRequest> Questions { get; } = new ReadOnlyCollection<QuestionRequest>(questions);
}