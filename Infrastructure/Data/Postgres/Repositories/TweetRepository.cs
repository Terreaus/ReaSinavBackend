using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class TweetRepository : Repository<Tweet, int>, ITweetRepository
    {
        public TweetRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Tweet>> GetAllAsync(Expression<Func<Tweet, bool>>? filter = null)
        {
            IQueryable<Tweet> reservationsQuery = PostgresContext.Set<Tweet>();

            if (filter != null)
            {
                reservationsQuery = reservationsQuery.Where(filter);
            }

            var reservations = await reservationsQuery
                .ToListAsync();

            return reservations;
        }




        public Task<IList<Tweet>> GetByTodoIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
