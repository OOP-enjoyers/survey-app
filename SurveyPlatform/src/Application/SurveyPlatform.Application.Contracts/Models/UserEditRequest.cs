namespace SurveyPlatform.Application.Contracts.Models;

public class UserEditRequest(int userId, int roleId, string fullName, string email, string password)
    : UserCreationRequest(roleId, fullName, email, password)
{
    public int UserId { get; set; } = userId;
}