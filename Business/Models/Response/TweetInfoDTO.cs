using System;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response;

public class TweetInfoDTO
{
    public int Id { get; set; }
    public int user_id { get; set; } = default!;
    public string Content { get; set; } = default!;


    public UserProfileDto? Users { get; set; }
}