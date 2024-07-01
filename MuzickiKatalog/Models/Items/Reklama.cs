using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Items
{
    public class Reklama
    {
        private int id;
        private string link;
        private string poster;
        public Reklama(int id,string link, string poster)
        {
            this.id = id;
            this.link = link;
            this.poster = poster;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        public string Poster
        {
            get { return poster; }
            set { poster = value; }
        }
    }
}
