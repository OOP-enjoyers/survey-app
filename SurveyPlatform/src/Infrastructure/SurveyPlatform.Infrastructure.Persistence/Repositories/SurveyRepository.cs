using Microsoft.EntityFrameworkCore;
using SurveyPlatform.Application.Abstractions.Persistence.Repositories;
using SurveyPlatform.Application.Models.Enums;
using SurveyPlatform.Application.Models.Models;
using SurveyPlatform.Infrastructure.Persistence.Contexts;
using SurveyPlatform.Infrastructure.Persistence.Models;

namespace SurveyPlatform.Infrastructure.Persistence.Repositories;

public class SurveyRepository(ApplicationDbContext context) : RepositoryBase<Survey, SurveyModel>(context), ISurveyRepository
{
    private readonly ApplicationDbContext _context = context;

    protected override DbSet<SurveyModel> DbSet => _context.Set<SurveyModel>();

    public Survey AddSurvey(Survey survey)
    {
        var surveyModel = MapFrom(survey);
        DbSet.Add(surveyModel);
        _context.SaveChanges();
        return MapTo(surveyModel);
    }

    public Survey GetSurvey(int surveyId)
    {
        var surveyModel = DbSet.FirstOrDefault(s => s.Id == surveyId);
        return (surveyModel != null ? new Survey(surveyModel.Id, surveyModel.Title, surveyModel.Description, (SurveyStatus)surveyModel.SurveyStatusId) : null)!;
    }

    public Survey EditSurvey(Survey survey)
    {
        var surveyModel = DbSet.FirstOrDefault(s => s.Id == survey.Id);
        if (surveyModel != null)
        {
            UpdateModel(surveyModel, survey);
            _context.SaveChanges();
            return survey;
        }

        return null!;
    }

    public Survey RemoveSurvey(int surveyId)
    {
        var surveyModel = DbSet.FirstOrDefault(s => s.Id == surveyId);
        if (surveyModel != null)
        {
            DbSet.Remove(surveyModel);
            _context.SaveChanges();
            return new Survey(surveyModel.Id, surveyModel.Title, surveyModel.Description, (SurveyStatus)surveyModel.SurveyStatusId);
        }

        return null!;
    }

    protected override SurveyModel MapFrom(Survey entity)
    {
        return new SurveyModel(
            entity.Id,
            entity.Title,
            entity.Description,
            (int)entity.SurveyStatus);
    }

    protected Survey MapTo(SurveyModel entity)
    {
        return new Survey(
            entity.Id,
            entity.Title,
            entity.Description,
            (SurveyStatus)entity.SurveyStatusId);
    }

    protected override bool Equal(Survey entity, SurveyModel model)
    {
        return entity.Id == model.Id;
    }

    protected override void UpdateModel(SurveyModel model, Survey entity)
    {
        model.SurveyStatusId = (int)entity.SurveyStatus;
        model.Title = entity.Title;
        model.Description = entity.Description;
    }
}