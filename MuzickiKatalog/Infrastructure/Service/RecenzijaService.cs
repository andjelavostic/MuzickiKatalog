using MuzickiKatalog.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class RecenzijaService:FileService
    {
        private List<Recenzija> recenzije;
        private string filePath = ".//..\\..\\..\\Infrastructure\\Data\\recenzije.json";
        public RecenzijaService()
        {
            this.recenzije = Deserialize<Recenzija>(this.filePath);
        }
        public override List<T> Deserialize<T>(string _filename)
        {
            return base.Deserialize<T>(_filename);
        }
        public override void Serialize<T>(string _filename, List<T> items)
        {
            base.Serialize<T>(_filename, items);
        }
        public void AddRecenzija(Recenzija recenzija)
        {
            recenzije = new List<Recenzija>();
            recenzije.Add(recenzija);
            Serialize<Recenzija>(filePath, recenzije);
        }
    }
}
