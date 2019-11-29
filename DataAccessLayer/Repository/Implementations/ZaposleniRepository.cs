using DataAccessLayer.Models;
using DataAccessLayer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repository.Implementations
{
    public class ZaposleniRepository : BaseRepository<Zaposleni>, IZaposleniRepository
    {
        private readonly ZaposleniDbContext context;

        public ZaposleniRepository(ZaposleniDbContext context) : base(context)
        {
            this.context = context;
        }

        public override IEnumerable<Zaposleni> GetAll()
        {
            return context.Zaposleni.Include(z => z.Odeljenje);
        }

        public override void Insert(Zaposleni t)
        {
            context.Add(t);
        }
    }
}
