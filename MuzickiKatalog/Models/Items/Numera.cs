using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Numera:MuzickiSadrzaj
    {
        private string naziv;
        private double trajanje;
        private DateTime datumObjave;
        
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public double Trajanje
        {
            get { return trajanje; }
            set { trajanje = value; }
        }
        public DateTime DatumObjave
        {
            get { return datumObjave; }
            set { datumObjave = value; }
        }
        public Numera(int id, string opis, string slika, Ocena ocenaUrednika, List<Ocena> oceneKorisnika, double trajanje, DateTime datumObjave, List<Zanr> zanrovi, string naziv)
        : base(id, opis, slika, ocenaUrednika, oceneKorisnika, zanrovi)
        {
            this.trajanje = trajanje;
            this.datumObjave = datumObjave;
            this.naziv = naziv;
        }
    }
}
