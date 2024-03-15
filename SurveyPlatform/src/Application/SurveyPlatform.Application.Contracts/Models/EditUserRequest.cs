using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Contracts.Models;

public abstract class EditUserRequest(int userId, UserRole role, string fullName, string email, string password) : AddUserRequest(role, fullName, email, password)
{
    public int UserId { get; set; } = userId;
}