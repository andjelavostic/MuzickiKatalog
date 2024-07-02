using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Izvodjac :MuzickiUmetnik
    {
        private string ime;
        private string prezime;
        public Izvodjac(int id, string opis, string slika, Ocena ocenaUrednika, List<Ocena> oceneKorisnika, string ime, string prezime, List<Zanr> zanrovi)
            :base(id,opis,slika,ocenaUrednika,oceneKorisnika, zanrovi)
        { 
            this.ime = ime;
            this.prezime = prezime;
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
     }
}
