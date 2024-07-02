using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Zanr
    {
        private int id;
        private string naziv;

        public int Id { get { return id; } set { id = value; } }
        public string Naziv
        { 
            get {  return naziv; }
            set { naziv = value; }
        }
        public Zanr() { }
        public Zanr(int id, string naziv)
        {
            this.id = id;  
            this.naziv = naziv;
        }
    }
}
