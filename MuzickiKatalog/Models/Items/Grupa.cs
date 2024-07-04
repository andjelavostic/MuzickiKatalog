using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Grupa : MuzickiUmetnik
    {
        private string naziv;
        private DateTime datumOsnivanja;
        private bool aktivna;
        private List<Izvodjac> clanovi;
        
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
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
        public Grupa(int id, string opis, string slika, Ocena ocenaUrednika, List<Ocena> oceneKorisnika, DateTime datumOsnivanja, bool aktivna, List<Izvodjac> clanovi, string naziv, List<Zanr> zanrovi,string idKreatora)
            : base(id, slika, opis, ocenaUrednika, oceneKorisnika, zanrovi,idKreatora)
        {
            this.datumOsnivanja = datumOsnivanja;
            this.aktivna = aktivna;
            this.clanovi = clanovi;
            this.naziv = naziv;
        }

    }
}
