﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class MuzickiUmetnik
    {
        private int id;
        private string slika;
        private string opis;
        private Ocena ocenaUrednika;
        private List<Ocena> oceneKorisnika;
        private List<Zanr> zanrovi;
        private string idKreatora;
        public List<Zanr> Zanrovi
        {
            get {return zanrovi; }
            set { zanrovi = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Slika
        {
            get { return slika; }
            set { slika = value; }
        }

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
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

        public MuzickiUmetnik()
        {
        }
        public string IdKreatora
        {
            get { return idKreatora; }
            set { idKreatora = value; }
        }
        public MuzickiUmetnik(int id, string opis, string slika, Ocena ocenaUrednika, List<Ocena> oceneKorisnika, List<Zanr> zanrovi,string idKreatora)
        {
            this.id = id;
            this.slika = slika;
            this.opis = opis;
            this.ocenaUrednika = ocenaUrednika;
            this.oceneKorisnika = oceneKorisnika;
            this.zanrovi = zanrovi;
            this.idKreatora = idKreatora;
        }

    }

}
