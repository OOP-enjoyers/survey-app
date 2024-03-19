using Microsoft.EntityFrameworkCore;
using SurveyPlatform.Application.Abstractions.Persistence.Repositories;
using SurveyPlatform.Application.Models.Models;
using SurveyPlatform.Infrastructure.Persistence.Contexts;
using SurveyPlatform.Infrastructure.Persistence.Models;

namespace SurveyPlatform.Infrastructure.Persistence.Repositories;

public class ResponseRepository(ApplicationDbContext context) : RepositoryBase<Response, ResponseModel>(context), IResponseRepository
{
    private readonly ApplicationDbContext _context = context;

    protected override DbSet<ResponseModel> DbSet => _context.Set<ResponseModel>();

    public Response AddResponse(Response response)
    {
        var responseModel = MapFrom(response);
        DbSet.Add(responseModel);
        _context.SaveChanges();
        return response;
    }

    public IReadOnlyCollection<Response> GetResponses(int questionId, int userId)
    {
        List<ResponseModel> allResponseModels = [.. DbSet.Where(r => r.UserId == userId && r.QuestionId == questionId)];
        IReadOnlyCollection<Response> allResponses = [];

        foreach (ResponseModel responseModel in allResponseModels)
        {
            allResponses.Append(new Response(responseModel.Id, responseModel.Content, responseModel.UserId, responseModel.QuestionId));
        }

        return allResponses;
    }

    public Response EditResponse(Response response)
    {
        var responseModel = DbSet.FirstOrDefault(r => r.Id == response.Id);
        if (responseModel != null)
        {
            UpdateModel(responseModel, response);
            _context.SaveChanges();
            return response;
        }

        return null!;
    }

    public Response RemoveResponse(Response response)
    {
        var responseModel = DbSet.FirstOrDefault(s => s.Id == response.Id);
        if (responseModel != null)
        {
            DbSet.Remove(responseModel);
            _context.SaveChanges();
            return new Response(responseModel.Id, responseModel.Content, responseModel.UserId, responseModel.QuestionId);
        }

        return null!;
    }

    protected override ResponseModel MapFrom(Response entity)
    {
        return new ResponseModel(
            entity.Id,
            entity.Content,
            entity.UserId,
            entity.QuestionId);
    }

    protected override bool Equal(Response entity, ResponseModel model)
    {
        return entity.Id == model.Id;
    }

    protected override void UpdateModel(ResponseModel model, Response entity)
    {
        model.Content = entity.Content;
    }
}