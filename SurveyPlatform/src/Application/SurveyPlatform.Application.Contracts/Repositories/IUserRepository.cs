using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Contracts;
namespace SurveyPlatform.Application.Contracts.Models;

public interface IUserRepository
{
    //Добавление пользователя в БД
    void Add(UserCreationRequest request);

    //Изменение пользователя
    void Update(User user);

    //Удаление пользователя
    void Remove(int userId);

    //Получить пользователя по Id
    void GetById(int userId);
}