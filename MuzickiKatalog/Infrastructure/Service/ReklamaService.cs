using MuzickiKatalog.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class ReklamaService:FileService
    {
        private List<Reklama> reklame;
        private string filePath = ".//..\\..\\..\\Infrastructure\\Data\\reklame.json";
        public ReklamaService()
        {
            this.reklame = Deserialize<Reklama>(this.filePath);
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
