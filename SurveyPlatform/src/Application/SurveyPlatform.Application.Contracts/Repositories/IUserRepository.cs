using SurveyPlatform.Application.Contracts.Models;
using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Contracts.Repositories;

public interface IUserRepository
{
    // Добавление пользователя
    void AddUser(AddUserRequest request);

    // Получить пользователя по Id
    User GetUser(int userId);

    // Изменение пользователя
    void EditUser(User user);

    // Удаление пользователя
    void RemoveUser(int userId);
}