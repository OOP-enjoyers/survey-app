using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Models.DTO.UserDto;
public class GetUserDto
{
    public UserRole UserRole { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public GetUserDto(UserRole userRole, string fullName, string email)
    {
        UserRole = userRole;
        FullName = fullName;
        Email = email;
    }
}
