using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Models.DTO.UserDto;
public class GetUserDto
{
    public UserRole UserRole { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public GetUserDto() { }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

    public GetUserDto(UserRole userRole, string fullName, string email)
    {
        UserRole = userRole;
        FullName = fullName;
        Email = email;
    }
}
