using AutoMapper;
using SurveyPlatform.Application.Models.DTO.ResponseDto;
using SurveyPlatform.Application.Models.DTO.SurveyDto;
using SurveyPlatform.Application.Models.DTO.UserDto;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Infrastructure.Persistence.Helpers;
public class ApplicationMapper : Profile
{
   public ApplicationMapper()
    {
        CreateMap<CreateUserDto, User>().ReverseMap();
        CreateMap<UpdateUserDto, User>().ReverseMap();

        CreateMap<Survey, GetSurveyDto>().ReverseMap();
        CreateMap<CreateSurveyDto, Survey>().ReverseMap();
        CreateMap<UpdateSurveyDto, Survey>().ReverseMap();

        CreateMap<Response, UpdateResponseDto>().ReverseMap();
    }
}
