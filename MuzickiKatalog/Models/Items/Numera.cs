using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Numera:Sadrzaj
    {
        private double trajanje;
        private Date datumObjave;
        public double Trajanje
        {
            get { return trajanje; }
            set { trajanje = value; }
        }
        public Date DatumObjave
        {
            get { return datumObjave; }
            set { datumObjave = value; }
        }
        public Numera(int id, string opis, string slika, int ocenaUrednika, List<int> oceneKorisnika, double trajanje, DateTime datumObjave)
        : base(id,opis, slika, ocenaUrednika, oceneKorisnika)
        {
            this.trajanje = trajanje;
            this.datumObjave = datumObjave;
        }
    }
}
