using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Infrastructure.Persistence.Repositories;

public interface IResponseRepository
{
    // Добавление ответа
    Response AddResponse(Response response);

    // Получение всех попыток ответов по id опроса и id пользователя
    IReadOnlyCollection<IReadOnlyCollection<Response>> GetResponses(int surveyId, int userId);

    // Изменение ответа
    Response EditResponse(Response response);

    // Удаление ответа
    Response RemoveResponse(Response response);
}