using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Ocena
    {
        private int id;
        private int vrednost;
        private string korisnik;
        public int Id { get { return id; } set { id = value; } }
        public int Vrednost { get { return vrednost; } set { vrednost = value; } }
        public string Korisnik { get { return korisnik; } set { korisnik = value; } }
    }
}
