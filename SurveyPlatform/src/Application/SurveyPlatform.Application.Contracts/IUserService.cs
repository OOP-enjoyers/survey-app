namespace SurveyPlatform.Application.Contracts;

using SurveyPlatform.Application.Contracts.Models;

public interface IUserService
{
    // Добавление нового пользователя
    void AddUser(UserCreationRequest request);

    // Изменение существующего пользователя
    void EditUser(UserEditRequest request);

    // Удаление пользователя
    void RemoveUser(int userId);

    // Получение пользователя по id
    void FindUser(int userId);
}