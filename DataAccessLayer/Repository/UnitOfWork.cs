using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Repository.Implementations;
using DataAccessLayer.Repository.Interfaces;

namespace DataAccessLayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ZaposleniDbContext context;

        public UnitOfWork(ZaposleniDbContext context)
        {
            this.context = context;
            ZaposleniRepository = new ZaposleniRepository(context);
        }

        public IZaposleniRepository ZaposleniRepository { get; set; }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
