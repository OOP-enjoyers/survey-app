using SurveyPlatform.Application.Abstractions.Persistence.Repositories;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Services;

public class SurveyService(ISurveyRepository surveyRepository, IQuestionRepository questionRepository) : ISurveyService
{
    // Добавление опроса
    public int AddSurvey(Survey survey)
    {
        Survey addedSurvey = surveyRepository.AddSurvey(survey);
        foreach (Question question in survey.Questions)
        {
            questionRepository.AddQuestion(question);
        }

        return addedSurvey.Id;
    }

    // Получение опроса по id
    public Survey GetSurvey(int surveyId)
    {
        Survey survey = surveyRepository.GetSurvey(surveyId);
        survey.Questions = questionRepository.GetQuestions(surveyId);

        return survey;
    }

    // Изменение опроса
    public int EditSurvey(Survey survey)
    {
        surveyRepository.EditSurvey(survey);

        IReadOnlyCollection<Question> prevQuestions = questionRepository.GetQuestions(survey.Id);

        foreach (Question question in survey.Questions)
        {
            questionRepository.AddQuestion(question);
        }

        foreach (Question question in prevQuestions)
        {
            questionRepository.RemoveQuestion(question.Id);
        }

        return survey.Id;
    }

    // Удаление опроса
    public int RemoveSurvey(int surveyId)
    {
        surveyRepository.RemoveSurvey(surveyId);
        IReadOnlyCollection<Question> prevQuestions = questionRepository.GetQuestions(surveyId);
        foreach (Question question in prevQuestions)
        {
            questionRepository.RemoveQuestion(question.Id);
        }

        return surveyId;
    }
}