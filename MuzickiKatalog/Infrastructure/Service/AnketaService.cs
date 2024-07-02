using MuzickiKatalog.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class AnketaService:FileService
    {
        private List<Anketa> ankete;
        private string filePath=".//..\\..\\..\\Infrastructure\\Data\\ankete.json";
        public AnketaService()
        {
            this.ankete = Deserialize<Anketa>(this.filePath);
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
