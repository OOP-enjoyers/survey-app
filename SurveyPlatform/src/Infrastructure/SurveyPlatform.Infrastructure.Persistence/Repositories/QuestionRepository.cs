using Microsoft.EntityFrameworkCore;
using SurveyPlatform.Application.Abstractions.Persistence.Repositories;
using SurveyPlatform.Application.Models.Enums;
using SurveyPlatform.Application.Models.Models;
using SurveyPlatform.Infrastructure.Persistence.Contexts;
using SurveyPlatform.Infrastructure.Persistence.Models;

namespace SurveyPlatform.Infrastructure.Persistence.Repositories;

public class QuestionRepository(ApplicationDbContext context) : RepositoryBase<Question, QuestionModel>(context), IQuestionRepository
{
    private readonly ApplicationDbContext _context = context;

    protected override DbSet<QuestionModel> DbSet => _context.Set<QuestionModel>();

    public Question AddQuestion(Question question)
    {
        var questionModel = MapFrom(question);
        DbSet.Add(questionModel);
        _context.SaveChanges();
        return question;
    }

    public IReadOnlyCollection<Question> GetQuestions(int surveyId)
    {
        IReadOnlyCollection<QuestionModel> allQuestionModels = [.. DbSet.Where(q => q.SurveyId == surveyId)];
        IReadOnlyCollection<Question> allQuestions = [];

        foreach (QuestionModel questionModel in allQuestionModels)
        {
            allQuestions.Append(new Question(questionModel.Id, questionModel.Title, questionModel.Description, questionModel.IsNecessary, questionModel.Answers, questionModel.SurveyId, (QuestionType)questionModel.QuestionTypeId));
        }

        return allQuestions;
    }

    public Question EditQuestion(Question question)
    {
        var questionModel = DbSet.FirstOrDefault(q => q.Id == question.Id);
        if (questionModel != null)
        {
            UpdateModel(questionModel, question);
            _context.SaveChanges();
            return question;
        }

        return null!;
    }

    public Question RemoveQuestion(int questionId)
    {
        var questionModel = DbSet.FirstOrDefault(u => u.Id == questionId);
        if (questionModel != null)
        {
            DbSet.Remove(questionModel);
            _context.SaveChanges();
            return new Question(questionModel.Id, questionModel.Title, questionModel.Description, questionModel.IsNecessary, questionModel.Answers, questionModel.SurveyId, (QuestionType)questionModel.QuestionTypeId);
        }

        return null!;
    }

    protected override QuestionModel MapFrom(Question entity)
    {
        return new QuestionModel(
            entity.Id,
            entity.Title,
            entity.Description,
            entity.IsNecessary,
            entity.Answers,
            entity.SurveyId,
            (int)entity.QuestionType);
    }

    protected override bool Equal(Question entity, QuestionModel model)
    {
        return entity.Id == model.Id;
    }

    protected override void UpdateModel(QuestionModel model, Question entity)
    {
        model.Title = entity.Title;
        model.Description = entity.Description;
        model.IsNecessary = entity.IsNecessary;
        model.Answers = entity.Answers;
        model.QuestionTypeId = (int)entity.QuestionType;
    }
}