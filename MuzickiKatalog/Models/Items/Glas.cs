using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Glas
    {
        private int id;
        private int idAnkete;
        private string idGlasaca;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdAnkete
        {
            get { return idAnkete;}
            set { idAnkete = value; }
        }
        public string Glasaca
        {
            get { return idGlasaca;}
            set { idGlasaca = value; }
        }
        public Glas(int id,int idAnkete,string idGlasaca)
        {
            this.id = id;
            this.idAnkete = idAnkete;
            this.idGlasaca = idGlasaca;
        }
    }
}
