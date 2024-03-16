using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Abstractions.Persistence.Repositories;

public interface IQuestionRepository
{
    // Добавление вопроса
    int AddQuestion(Question question);

    // Получение вопросов по id опроса
    IReadOnlyCollection<Question> GetQuestions(int surveyId);

    // Изменение вопроса
    int EditQuestion(Question question);

    // Удаление вопроса
    int RemoveQuestion(Question question);
}