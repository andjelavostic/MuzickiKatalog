﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Anketa
    {
        private Period period;
        private DateTime datumPocetka;
        private DateTime datumKraja;
        private int idOdabira;
        private string opis;

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }
        public Period Period
        {
            get { return period; }
            set { period = value; }
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
        public int IdOdabira
        {
            get { return idOdabira;}
            set { idOdabira = value; }
        }
        public Anketa(Period period,int  idOdabira, DateTime datumPocetka, DateTime datumKraja, string opis)
        {
            this.period = period;
            this.idOdabira = idOdabira;
            this.datumPocetka = datumPocetka;
            this.datumKraja = datumKraja;
            this.opis = opis;
        }
    }
    public enum Period
    {
        godina,
        mesec
    }
}
