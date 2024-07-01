using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Izvodjenje
    {
        private int id;
        private int idSadrzaja;
        private DateTime datum;
        private string mesto;
        private string rezolucija;
        private bool uzivo;
        private bool preuzimanje;
        public Izvodjenje(int id,int idSadrzaja, DateTime datum, string mesto, string rezolucija, bool uzivo, bool preuzimanje)
        {
            this.id = id;
            this.idSadrzaja = idSadrzaja;
            this.datum = datum;
            this.mesto = mesto;
            this.rezolucija = rezolucija;
            this.uzivo = uzivo;
            this.preuzimanje = preuzimanje;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdSadrzaja
        {
            get { return idSadrzaja; }
            set { idSadrzaja = value; }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public string Mesto
        {
            get { return mesto; }
            set { mesto = value; }
        }

        public string Rezolucija
        {
            get { return rezolucija; }
            set { rezolucija = value; }
        }

        public bool Uzivo
        {
            get { return uzivo; }
            set { uzivo = value; }
        }

        public bool Preuzimanje
        {
            get { return preuzimanje; }
            set { preuzimanje = value; }
        }
    
}
}
