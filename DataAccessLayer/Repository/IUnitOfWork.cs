using DataAccessLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repository
{
    public interface IUnitOfWork
    {
        IZaposleniRepository ZaposleniRepository { get; set; }
        void Save();

    }
}
