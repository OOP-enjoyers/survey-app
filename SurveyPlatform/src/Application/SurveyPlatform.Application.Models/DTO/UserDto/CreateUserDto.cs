using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Models.DTO.UserDto;
public class CreateUserDto
{
    public UserRole UserRole { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public CreateUserDto(UserRole userRole, string fullName, string email, string password)
    {
        UserRole = userRole;
        FullName = fullName;
        Email = email;
        Password = password;
    }
}
