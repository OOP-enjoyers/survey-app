using SurveyPlatform.Application.Contracts;
using SurveyPlatform.Application.Models;
using SurveyPlatform.Infrastructure.Persistence.Repositories;

namespace SurveyPlatform.Application.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    // Добавление пользователя
    public int AddUser(User user)
    {
        return userRepository.AddUser(user).Id;
    }

    // Получение пользователя по id
    public User GetUser(int userId)
    {
        return userRepository.GetUser(userId);
    }

    // Изменение пользователя
    public int EditUser(User user)
    {
        return userRepository.EditUser(user).Id;
    }

    // Удаление пользователя
    public int RemoveUser(int userId)
    {
        return userRepository.RemoveUser(userId).Id;
    }
}