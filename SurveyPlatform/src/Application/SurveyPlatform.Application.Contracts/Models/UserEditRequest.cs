namespace SurveyPlatform.Application.Contracts.Models;

public class UserEditRequest(int userId, int roleId, string fullName, string email, string password)
{
    public int UserId { get; set; } = userId;

    public int RoleId { get; set; } = roleId;

    public string FullName { get; set; } = fullName;

    public string Email { get; set; } = email;

    public string Password { get; set; } = password;
}