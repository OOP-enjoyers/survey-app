﻿namespace SurveyPlatform.Application.Models.DTO.ResponseDto;
public class GetResponseDto
{
    public string[] Content { get; private set; }

    public int UserId { get; set; }

    public int QuestionId { get; set; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public GetResponseDto() { }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

    public GetResponseDto(string[] content, int userId, int questionId)
    {
        Content = content;
        UserId = userId;
        QuestionId = questionId;
    }
}