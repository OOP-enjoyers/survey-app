using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Contracts;

public interface IUserService
{
    // Добавление пользователя
    int AddUser(User user);

    // Получение пользователя по id
    User GetUser(int userId);

    // Изменение пользователя
    int EditUser(User user);

    // Удаление пользователя
    int RemoveUser(int userId);
}