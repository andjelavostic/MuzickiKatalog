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
    }
}
