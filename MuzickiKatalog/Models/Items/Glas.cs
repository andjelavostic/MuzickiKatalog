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
        private int idGlasaca;
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
        public int Glasaca
        {
            get { return idGlasaca;}
            set { idGlasaca = value; }
        }
        public Glas(int id,int idAnkete,int idGlasaca)
        {
            this.id = id;
            this.idAnkete = idAnkete;
            this.idGlasaca = idGlasaca;
        }
    }
}
