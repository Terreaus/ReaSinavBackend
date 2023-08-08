

using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class TweetConfiguration : BaseConfiguration<Tweet, int>
    {
        public override void Configure(EntityTypeBuilder<Tweet> builder)
        {
            builder.ToTable("Tweet");

            builder.Property(r => r.Content)
                           .IsRequired()
                           .HasMaxLength(100);




        }
    }
}
