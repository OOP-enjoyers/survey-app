using SurveyPlatform.Application.Contracts;
using SurveyPlatform.Application.Contracts.Models;
using SurveyPlatform.Application.Contracts.Repositories;
using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    // Добавление пользователя
    public void AddUser(AddUserRequest request)
    {
        userRepository.AddUser(request);
    }

    // Получение пользователя по id
    public User GetUser(int userId)
    {
        return userRepository.GetUser(userId);
    }

    // Изменение пользователя
    public void EditUser(EditUserRequest request)
    {
        User user = new(request.UserId, request.Role, request.FullName, request.Email, request.Password);
        userRepository.EditUser(user);
    }

    // Удаление пользователя
    public void RemoveUser(int userId)
    {
        userRepository.RemoveUser(userId);
    }
}