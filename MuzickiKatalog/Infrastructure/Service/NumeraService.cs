using MuzickiKatalog.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class NumeraService:FileService
    {
        private List<Numera> numere;
        private string filePath = ".//..\\..\\..\\Infrastructure\\Data\\numere.json";
        public NumeraService()
        {
            this.numere = Deserialize<Numera>(this.filePath);
        }
        public override List<T> Deserialize<T>(string _filename)
        {
            return base.Deserialize<T>(_filename);
        }
        public override void Serialize<T>(string _filename, List<T> items)
        {
            base.Serialize<T>(_filename, items);
        }
        public List<Numera> GetAll()
        {
            return numere;
        }
        public Numera GetByID(int id)
        {
            return numere.FirstOrDefault(numera => numera.Id == id);
        }
    }
}
