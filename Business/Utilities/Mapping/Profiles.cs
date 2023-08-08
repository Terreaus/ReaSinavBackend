using Business.Models.Request;
using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {

        CreateMap<RegisterDto, User>();


        CreateMap<UserUpdateDto, User>();


        CreateMap<User, Models.Response.UserProfileDto>();



        CreateMap<TweetCreateDTO, Tweet>();
        CreateMap<TweetUpdateDTO, Tweet>();
        CreateMap<Tweet, TweetInfoDTO>();
    }

}