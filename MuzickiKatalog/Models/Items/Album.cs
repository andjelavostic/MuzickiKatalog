using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Album:MuzickiSadrzaj
    {
        private string naziv;
        private List<Numera> numere;
        private TipAlbuma tip;
        private string izdavackaKuca;
        private DateTime datumIzdavanja;
        public Album(int id, string opis, string slika, Ocena ocenaUrednika, List<Ocena> oceneKorisnika, List<Numera> numere, TipAlbuma tip, string izdavackaKuca, DateTime datumIzdavanja, List<Zanr> zanrovi, string naziv,string idKreatora)
        : base(id, opis, slika, ocenaUrednika, oceneKorisnika, zanrovi,idKreatora)
        {
            this.numere = numere;
            this.tip = tip;
            this.izdavackaKuca = izdavackaKuca;
            this.datumIzdavanja = datumIzdavanja;
            this.naziv = naziv;
        }
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public DateTime DatumIzdavanja
        {
            get { return datumIzdavanja; }
            set { datumIzdavanja = value; }
        }
        public List<Numera> Numere
        {
            get { return numere; }
            set { numere = value; }
        }
        public TipAlbuma Tip
        {
            get { return tip; }
            set { tip = value; }
        }

        public string IzdavackaKuca
        {
            get { return izdavackaKuca; }
            set { izdavackaKuca = value; }
        }
    }
    public enum TipAlbuma
    {
        CD,
        ploca,
        digitalno
    }
}
