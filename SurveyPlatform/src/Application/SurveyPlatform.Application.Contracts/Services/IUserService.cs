using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Contracts.Services;

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