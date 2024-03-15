using SurveyPlatform.Application.Contracts;
using SurveyPlatform.Application.Models;
using SurveyPlatform.Infrastructure.Persistence.Repositories;

namespace SurveyPlatform.Application.Services;

public class SurveyService(ISurveyRepository surveyRepository, IQuestionRepository questionRepository) : ISurveyService
{
    // Добавление опроса
    public int AddSurvey(Survey survey, IReadOnlyCollection<Question> questions)
    {
        Survey addedSurvey = surveyRepository.AddSurvey(survey);
        foreach (Question question in questions)
        {
            questionRepository.AddQuestion(question);
        }

        return addedSurvey.Id;
    }

    // Получение опроса по id
    public (Survey Survey, IReadOnlyCollection<Question> Questions) GetSurvey(int surveyId)
    {
        Survey survey = surveyRepository.GetSurvey(surveyId);
        IReadOnlyCollection<Question> questions = questionRepository.GetQuestions(surveyId);

        return (survey, questions);
    }

    // Изменение опроса
    public int EditSurvey(Survey survey, IReadOnlyCollection<Question> questions)
    {
        surveyRepository.EditSurvey(survey);
        IReadOnlyCollection<Question> prevQuestions = questionRepository.GetQuestions(survey.Id);
        foreach (Question question in prevQuestions)
        {
            questionRepository.RemoveQuestion(question);
        }

        foreach (Question question in questions)
        {
            questionRepository.AddQuestion(question);
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
            questionRepository.RemoveQuestion(question);
        }

        return surveyId;
    }
}