using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Abstractions.Persistence.Repositories;

public interface IQuestionRepository
{
    // Добавление вопроса
    Question AddQuestion(Question question);

    // Получение вопросов по id опроса
    IReadOnlyCollection<Question> GetQuestions(int surveyId);

    // Изменение вопроса
    Question EditQuestion(Question question);

    // Удаление вопроса
    Question RemoveQuestion(int questionId);
}