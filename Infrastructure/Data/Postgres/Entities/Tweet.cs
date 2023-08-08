﻿using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Tweet : Entity<int>
    {
        public string Content { get; set; } = default!;

        public int user_id { get; set; }

        public User? User { get; set; }



    }
}
