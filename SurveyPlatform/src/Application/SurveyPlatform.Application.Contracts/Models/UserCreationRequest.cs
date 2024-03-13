namespace SurveyPlatform.Application.Contracts.Models;

public class UserCreationRequest(int roleId, string fullName, string email, string password)
{
    public int RoleId { get; set; } = roleId;

    public string FullName { get; set; } = fullName;

    public string Email { get; set; } = email;

    public string Password { get; set; } = password;
}