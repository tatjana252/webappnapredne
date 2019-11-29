using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Zaposleni
    {
        public int ZaposleniId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int OdeljenjeId { get; set; }
        public Odeljenje Odeljenje { get; set; }
    }
}
