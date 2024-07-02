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
        private int izvodjacId;
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
        public int IzvodjacId
        {
            get { return izvodjacId; }
            set { izvodjacId = value; }
        }
        public Numera(int id, string opis, string slika, Ocena ocenaUrednika, List<Ocena> oceneKorisnika, double trajanje, DateTime datumObjave, List<Zanr> zanrovi, string naziv,int izvodjacId)
        : base(id, opis, slika, ocenaUrednika, oceneKorisnika, zanrovi)
        {
            this.trajanje = trajanje;
            this.datumObjave = datumObjave;
            this.naziv = naziv;
            this.izvodjacId = izvodjacId;
        }
    }
}
