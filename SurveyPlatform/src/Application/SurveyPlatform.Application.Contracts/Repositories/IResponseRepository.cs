namespace SurveyPlatform.Application.Contracts.Repositories;

public interface IResponseRepository
{
    // Добавление ответа в БД
    void Add(int userId, int questionId, IReadOnlyCollection<string> content);
}