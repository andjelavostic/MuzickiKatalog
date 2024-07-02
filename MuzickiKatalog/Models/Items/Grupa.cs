using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Grupa : MuzickiUmetnik
    {
        private DateTime datumOsnivanja;
        private bool aktivna;
        private List<Izvodjac> clanovi;
        public DateTime DatumOsnivanja
        {
            get { return datumOsnivanja; }
            set { datumOsnivanja = value; }
        }

        public bool Aktivna
        {
            get { return aktivna; }
            set { aktivna = value; }
        }

        public List<Izvodjac> Clanovi
        {
            get { return clanovi; }
            set { clanovi = value; }
        }

        public Grupa() : base()
        {
        }
        public Grupa(int id, string slika, string opis, Ocena ocenaUrednika, List<Ocena> oceneKorisnika, DateTime datumOsnivanja, bool aktivna, List<Izvodjac> clanovi)
            : base(id, slika, opis, ocenaUrednika, oceneKorisnika)
        {
            this.datumOsnivanja = datumOsnivanja;
            this.aktivna = aktivna;
            this.clanovi = clanovi;
        }

    }
}
