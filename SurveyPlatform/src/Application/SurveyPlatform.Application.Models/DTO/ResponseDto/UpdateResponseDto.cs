namespace SurveyPlatform.Application.Models.DTO.ResponseDto;
public class UpdateResponseDto
{
    public string[] Content { get; private set; }

    public int UserId { get; set; }

    public int QuestionId { get; set; }

    public UpdateResponseDto(string[] content, int userId, int questionId)
    {
        Content = content;
        UserId = userId;
        QuestionId = questionId;
    }
}
