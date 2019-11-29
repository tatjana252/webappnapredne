using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;

namespace BusinessLogicLayer
{
    public class ZaposleniService : IZaposleniService
    {
        private readonly IUnitOfWork unitOfWork;

        public ZaposleniService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Zaposleni> GetAll()
        {
            return unitOfWork.ZaposleniRepository.GetAll();
        }

        public void Insert(Zaposleni t)
        {
            unitOfWork.ZaposleniRepository.Insert(t);
            unitOfWork.Save();
        }
    }
}
