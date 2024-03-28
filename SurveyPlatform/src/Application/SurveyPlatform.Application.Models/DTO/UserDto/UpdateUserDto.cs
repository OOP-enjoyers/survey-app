using SurveyPlatform.Application.Models.Enums;

namespace SurveyPlatform.Application.Models.DTO.UserDto;
public class UpdateUserDto
{
    public int Id { get; set; }

    public UserRole UserRole { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public UpdateUserDto() { }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

    public UpdateUserDto(int id, UserRole userRole, string fullName, string email, string password)
    {
        Id = id;
        UserRole = userRole;
        FullName = fullName;
        Email = email;
        Password = password;
    }
}
