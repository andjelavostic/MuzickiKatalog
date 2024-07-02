using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class MuzickiSadrzaj
    {
        private int id;
        private string opis;
        private string slika;
        private List<Zanr> zanrovi;
        private Ocena ocenaUrednika;
        private List<Ocena> oceneKorisnika;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }
        public string Slika
        {
            get { return slika; }
            set { slika = value; }
        }
        public List<Zanr> Zanrovi
        {
            get { return zanrovi; }
            set { zanrovi = value; }
        }
        public Ocena OcenaUrednika
        {
            get { return ocenaUrednika; }
            set { ocenaUrednika = value; }
        }
        public List<Ocena> OceneKorisnika
        {
            get { return oceneKorisnika; }
            set { oceneKorisnika = value; }
        }
        public MuzickiSadrzaj(int id,string opis, string slika, Ocena ocenaUrednika, List<Ocena> oceneKorisnika, List<Zanr> zanrovi)
        {
            this.id = id;
            this.opis = opis;
            this.slika = slika;
            this.ocenaUrednika=ocenaUrednika;
            this.oceneKorisnika=oceneKorisnika;
            this.zanrovi = zanrovi;
        }
    }
}
