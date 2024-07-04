using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Users
{
    public class Urednik:Korisnik
    {
        private List<string> specijalnost;
        public List<string> Specijalnost
        {
            get { return specijalnost; }
            set { specijalnost = value; }   
        }
        public Urednik(string ime, string prezime, string email, string lozinka,List<string> specijalnost) :
            base(ime, prezime, email, lozinka)
        {
            this.specijalnost= specijalnost;
        }
    }
}
