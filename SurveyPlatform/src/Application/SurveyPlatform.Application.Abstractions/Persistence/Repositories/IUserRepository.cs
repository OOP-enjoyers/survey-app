using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Abstractions.Persistence.Repositories;

public interface IUserRepository
{
    // Добавление пользователя
    User AddUser(User user);

    // Получить пользователя по Id
    User GetUser(int userId);

    // Изменение пользователя
    User EditUser(User user);

    // Удаление пользователя
    User RemoveUser(int userId);
}