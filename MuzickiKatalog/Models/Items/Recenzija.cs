using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Recenzija
    {
        public string komentar;
        public int idSadrzaja;
        public string idKorisnik;
        public Date datum;
        public Recenzija(string komentar, int idSadrzaja, string idKorisnik)
        {
            this.komentar = komentar;
            this.idSadrzaja = idSadrzaja;
            this.idKorisnik = idKorisnik;
            this.datum = DateTime.Now;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Komentar
        {
            get { return komentar; }
            set { komentar = value; }
        }

        public int IdSadrzaja
        {
            get { return idSadrzaja; }
            set { idSadrzaja = value; }
        }

        public string IdKorisnik
        {
            get { return idKorisnik; }
            set { idKorisnik = value; }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
    }
}
