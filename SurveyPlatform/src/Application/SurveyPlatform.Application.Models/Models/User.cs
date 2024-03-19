using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Models.Models;

public class User
{
    public int Id { get; private set; }

    public UserRole UserRole { get; private set; }

    public string FullName { get; private set; }

    public string Email { get; private set; }

    public string Password { get; private set; }

    public User(int id, UserRole userRole, string fullName, string email, string password)
    {
        Id = id;
        UserRole = userRole;
        FullName = fullName;
        Email = email;
        Password = password;
    }
}