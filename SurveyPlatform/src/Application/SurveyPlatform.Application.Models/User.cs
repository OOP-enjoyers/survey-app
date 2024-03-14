#pragma warning disable IDE0051
using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Models;

public class User(
    int id,
    Role role,
    string fullName,
    string email,
    string password)
{
    public int Id { get; private set; } = id;

    public Role Role { get; set; } = role;

    public string FullName { get; private set; } = fullName;

    public string Email { get; private set; } = email;

    private string Password { get; set; } = password;
}
#pragma warning restore IDE0051