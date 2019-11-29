using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Repository.Implementations;
using DataAccessLayer.Repository.Interfaces;

namespace DataAccessLayer.Repository
{
    public class InMemUnitOfWork : IUnitOfWork
    {
        public InMemUnitOfWork()
        {

        }
        public IZaposleniRepository ZaposleniRepository { get; set; } = new InMemoryZaposleniRepository();

        public void Save()
        {
            
        }
    }
}
