using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Anketa
    {
        private Period period;
        private List<int> glasovi; //id numere/albuma/izvodjaca
        private DateTime datumPocetka;
        private DateTime datumKraja;
        public Period Period
        {
            get { return period; }
            set { period = value; }
        }

        public List<int> Glasovi
        {
            get { return glasovi; }
            set { glasovi = value; }
        }

        public DateTime DatumPocetka
        {
            get { return datumPocetka; }
            set { datumPocetka = value; }
        }

        public DateTime DatumKraja
        {
            get { return datumKraja; }
            set { datumKraja = value; }
        }
        public Anketa(Period period, List<int> glasovi, DateTime datumPocetka, DateTime datumKraja)
        {
            this.period = period;
            this.glasovi = glasovi;
            this.datumPocetka = datumPocetka;
            this.datumKraja = datumKraja;
        }
    }
    public enum Period
    {
        godina,
        mesec
    }
}
