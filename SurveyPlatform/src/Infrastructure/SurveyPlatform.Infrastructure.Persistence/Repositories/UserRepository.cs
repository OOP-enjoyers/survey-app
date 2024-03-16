using Microsoft.EntityFrameworkCore;
using SurveyPlatform.Application.Abstractions.Persistence.Repositories;
using SurveyPlatform.Application.Models.Enums;
using SurveyPlatform.Application.Models.Models;
using SurveyPlatform.Infrastructure.Persistence.Contexts;
using SurveyPlatform.Infrastructure.Persistence.Models;

namespace SurveyPlatform.Infrastructure.Persistence.Repositories;

public class UserRepository(ApplicationDbContext context) : RepositoryBase<User, UserModel>(context), IUserRepository
{
    private readonly ApplicationDbContext _context = context;

    protected override DbSet<UserModel> DbSet => _context.Set<UserModel>();

    public User AddUser(User user)
    {
        var userModel = MapFrom(user);
        DbSet.Add(userModel);
        _context.SaveChanges();
        return user;
    }

    public User GetUser(int userId)
    {
        var userModel = DbSet.FirstOrDefault(u => u.Id == userId);
        return (userModel != null ? new User(userModel.Id, (UserRole)userModel.UserRoleId, userModel.FullName, userModel.Email, userModel.Password) : null)!;
    }

    public User EditUser(User user)
    {
        var userModel = DbSet.FirstOrDefault(u => u.Id == user.Id);
        if (userModel != null)
        {
            UpdateModel(userModel, user);
            _context.SaveChanges();
            return user;
        }

        return null!;
    }

    public User RemoveUser(int userId)
    {
        var userModel = DbSet.FirstOrDefault(u => u.Id == userId);
        if (userModel != null)
        {
            DbSet.Remove(userModel);
            _context.SaveChanges();
            return new User(userModel.Id, (UserRole)userModel.UserRoleId, userModel.FullName, userModel.Email, userModel.Password);
        }

        return null!;
    }

    protected override UserModel MapFrom(User entity)
    {
        return new UserModel(
            entity.Id,
            (int)entity.UserRole,
            entity.FullName,
            entity.Email,
            entity.Password);
    }

    protected override bool Equal(User entity, UserModel model)
    {
        return entity.Id == model.Id;
    }

    protected override void UpdateModel(UserModel model, User entity)
    {
        model.FullName = entity.FullName;
        model.Email = entity.Email;
        model.Password = entity.Password;
    }
}