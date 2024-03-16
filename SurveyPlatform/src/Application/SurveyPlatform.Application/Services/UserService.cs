using SurveyPlatform.Application.Abstractions.Persistence.Repositories;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    // Добавление пользователя
    public int AddUser(User user)
    {
        return _userRepository.AddUser(user).Id;
    }

    // Получение пользователя по id
    public User GetUser(int userId)
    {
        return _userRepository.GetUser(userId);
    }

    // Изменение пользователя
    public int EditUser(User user)
    {
        return _userRepository.EditUser(user).Id;
    }

    // Удаление пользователя
    public int RemoveUser(int userId)
    {
        return _userRepository.RemoveUser(userId).Id;
    }
}