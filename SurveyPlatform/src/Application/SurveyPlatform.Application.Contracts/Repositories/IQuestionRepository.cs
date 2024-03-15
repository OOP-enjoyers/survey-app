using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Contracts.Repositories;

public interface IQuestionRepository
{
    // Добавление нового вопроса
    void AddQuestion(string title, string description, IReadOnlyCollection<string> answers, int typeId, int surveyId);

    // Получение списка вопросов по id опроса
    IReadOnlyCollection<Question> GetBySurveyId(int surveyId);
}