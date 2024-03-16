namespace SurveyPlatform.Infrastructure.Persistence.Models;

public class UserModel
{
    public int Id { get; set; }

    public int UserRoleId { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public UserModel(int id, int userRoleId, string fullName, string email, string password)
    {
        Id = id;
        UserRoleId = userRoleId;
        FullName = fullName;
        Email = email;
        Password = password;
    }
}