using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Contracts.Models;

public abstract class AddUserRequest(UserRole role, string fullName, string email, string password)
{
    public UserRole Role { get; set; } = role;

    public string FullName { get; set; } = fullName;

    public string Email { get; set; } = email;

    public string Password { get; set; } = password;
}