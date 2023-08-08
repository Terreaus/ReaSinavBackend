using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class TweetCreateDTO
    {
        public int user_id { get; set; }
        public string Content { get; set; } = default!;

    }
}
