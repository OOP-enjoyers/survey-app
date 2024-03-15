using SurveyPlatform.Application.Contracts.Models;

namespace SurveyPlatform.Application.Contracts;
public interface IUserService
{
    // Добавление нового пользователя
    void AddUser(UserCreationRequest request);

    // Изменение существующего пользователя
    void EditUser(UserEditRequest request);

    // Удаление пользователя
    void RemoveUser(int userId);

    // Получение пользователя по id
    void GetUser(int userId);
}