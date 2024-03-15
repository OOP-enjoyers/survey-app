using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Application.Contracts;

public interface IQuestionRepository
{
    //Добавление нового вопроса
    int Add(string title, string description, IList<string> content, int typeId, int surveyId);

    //Получение списка вопросов по id опроса
    IReadOnlyCollection<Question> GetBySurveyId(int surveyId);
}