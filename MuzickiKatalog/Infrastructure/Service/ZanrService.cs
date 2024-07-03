using MuzickiKatalog.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class ZanrService:FileService
    {
        private List<Zanr> zanrovi;
        private string filePath = ".//..\\..\\..\\Infrastructure\\Data\\zanrovi.json";
        public ZanrService()
        {
            this.zanrovi = Deserialize<Zanr>(this.filePath);
        }
        public List<Zanr> GetAll()
        {
            return zanrovi;
        }
        public void AddZanr(Zanr zanr)
        {
            zanrovi.Add(zanr);
            Serialize<Zanr>(filePath, zanrovi);
        }
        public Zanr FindZanr(string trazeniNaziv)
        {
            return zanrovi.Find(z => z.Naziv == trazeniNaziv);
        }
        public override List<T> Deserialize<T>(string _filename)
        {
            return base.Deserialize<T>(_filename);
        }
        public override void Serialize<T>(string _filename, List<T> items)
        {
            base.Serialize<T>(_filename, items);
        }
    }
}
