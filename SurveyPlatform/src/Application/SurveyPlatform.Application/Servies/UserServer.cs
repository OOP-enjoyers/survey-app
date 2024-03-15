using SurveyPlatform.Application.Contracts;
using SurveyPlatform.Application.Contracts.Models;
using  SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application;

public class UserService(): IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    
    public void AddUser(UserCreationRequest request)
    {
        _userRepository.Add(request);
    }

    // Изменение существующего пользователя
    public void EditUser(UserEditRequest request)
    {
        User user = new(request.UserId, request.RoleId, request.FullName, request.Email, request.Password);
        _userRepository.Update(user);
    }

    // Удаление пользователя
    public void RemoveUser(int userId)
    {
        _userRepository.Remove(userId);
    }

    // Получение пользователя по id
    public void GetUser(int userId)
    {
        _userRepository.GetById(userId);
    }
}