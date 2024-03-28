using AutoMapper;
using SurveyPlatform.Application.Models.DTO;
using SurveyPlatform.Application.Models.DTO.ResponseDto;
using SurveyPlatform.Application.Models.DTO.SurveyDto;
using SurveyPlatform.Application.Models.DTO.UserDto;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Infrastructure.Persistence.Helpers;
public class ApplicationMapper : Profile
{
   public ApplicationMapper()
    {
        CreateMap<User, GetUserDto>();
        CreateMap<CreateUserDto, User>();
        CreateMap<UpdateUserDto, User>();

        CreateMap<Survey, GetSurveyDto>();
        CreateMap<CreateSurveyDto, Survey>();
        CreateMap<UpdateSurveyDto, Survey>();

        CreateMap<Response, UpdateResponseDto>();
        CreateMap<Question, QuestionDto>();
    }
}
