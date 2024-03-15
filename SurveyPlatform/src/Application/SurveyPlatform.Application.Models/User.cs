#pragma warning disable IDE0051

using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Models;

public class User(
    int id,
    UserRole userRole,
    string fullName,
    string email,
    string password)
{
    public int Id { get; private set; } = id;

    public UserRole UserRole { get; private set; } = userRole;

    public string FullName { get; private set; } = fullName;

    public string Email { get; private set; } = email;

    public string Password { get; set; } = password;
}

#pragma warning restore IDE0051