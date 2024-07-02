using MuzickiKatalog.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    internal class GrupaService : FileService
    {
        private List<Grupa> grupe;
        private string filePath = ".//..\\..\\..\\Infrastructure\\Data\\grupe.json";
        public GrupaService()
        {
            this.grupe = Deserialize<Grupa>(this.filePath);
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
