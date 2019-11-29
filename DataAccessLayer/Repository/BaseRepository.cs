using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly ZaposleniDbContext context;

        public BaseRepository(ZaposleniDbContext context)
        {
            this.context = context;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }

        public virtual void Insert(T t)
        {
            context.Add(t);
        }
    }
}
