using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Sadrzaj
    {
        private int id;
        private string opis;
        private string slika;
        private List<string> zanrovi;
        private int ocenaUrednika;
        private List<int> oceneKorisnika;
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
        public List<string> Zanrovi
        {
            get { return zanrovi; }
            set { zanrovi = value; }
        }
        public int OcenaUrednika
        {
            get { return ocenaUrednika; }
            set { ocenaUrednika = value; }
        }
        public List<int> OceneKorisnika
        {
            get { return oceneKorisnika; }
            set { oceneKorisnika = value; }
        }
        public Sadrzaj(int id,string opis, string slika, int ocenaUrednika, List<int> oceneKorisnika)
        {
            this.id = id;
            this.opis = opis;
            this.slika = slika;
            this.ocenaUrednika=ocenaUrednika;
            this.oceneKorisnika=oceneKorisnika;
        }
    }
}
