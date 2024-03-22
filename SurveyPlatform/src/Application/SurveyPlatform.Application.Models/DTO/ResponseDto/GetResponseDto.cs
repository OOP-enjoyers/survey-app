namespace SurveyPlatform.Application.Models.DTO.ResponseDto;
public class GetResponseDto
{
    public string[] Content { get; private set; }

    public int UserId { get; set; }

    public int QuestionId { get; set; }

    public GetResponseDto(string[] content, int userId, int questionId)
    {
        Content = content;
        UserId = userId;
        QuestionId = questionId;
    }
}
