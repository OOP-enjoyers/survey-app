using SurveyPlatform.Application.Contracts.Models;
using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Contracts;

public interface IUserService
{
    // Добавление нового пользователя
    void AddUser(AddUserRequest request);

    // Получение пользователя по id
    User GetUser(int userId);

    // Изменение существующего пользователя
    void EditUser(EditUserRequest request);

    // Удаление пользователя
    void RemoveUser(int userId);
}