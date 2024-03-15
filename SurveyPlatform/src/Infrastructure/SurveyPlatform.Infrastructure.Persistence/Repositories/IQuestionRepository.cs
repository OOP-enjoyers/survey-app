using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Infrastructure.Persistence.Repositories;

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