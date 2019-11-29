using DataAccessLayer.Models;
using DataAccessLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repository.Implementations
{
    public class InMemoryZaposleniRepository : IZaposleniRepository
    {
        private List<Zaposleni> zaposleni = new List<Zaposleni>();
        public IEnumerable<Zaposleni> GetAll()
        {
            return zaposleni;
        }

        public void Insert(Zaposleni t)
        {
            zaposleni.Add(t);
        }
    }
}
