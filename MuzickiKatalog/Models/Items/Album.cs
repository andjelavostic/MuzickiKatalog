using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Album:Sadrzaj
    {
        private List<Numera> numere;
        private TipAlbuma tip;
        private string izdavackaKuca;
        public Album(int id, string opis, string slika, int ocenaUrednika, List<int> oceneKorisnika, List<Numera> numere, TipAlbuma tip, string izdavackaKuca)
        : base(id, opis, slika, ocenaUrednika, oceneKorisnika)
        {
            this.numere = numere;
            this.tip = tip;
            this.izdavackaKuca = izdavackaKuca;
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
