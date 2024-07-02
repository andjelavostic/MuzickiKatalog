using MuzickiKatalog.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class IzvodjenjeService:FileService
    {
        private List<Izvodjenje> izvodjenja;
        private string filePath= ".//..\\..\\..\\Infrastructure\\Data\\izvodjenja.json";
        public IzvodjenjeService()
        {
            this.izvodjenja = Deserialize<Izvodjenje>(this.filePath);
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
