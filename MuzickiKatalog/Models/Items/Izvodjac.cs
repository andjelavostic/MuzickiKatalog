using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Izvodjac:Sadrzaj
    {
        public Izvodjac(int id, string opis, string slika, int ocenaUrednika, List<int> oceneKorisnika)
            :base(id,opis,slika,ocenaUrednika,oceneKorisnika)
        { 
        }
     }
}
