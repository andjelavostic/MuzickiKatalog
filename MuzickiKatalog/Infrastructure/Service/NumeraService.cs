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
        private List<Numera> numere=new List<Numera>();
        private string filePath = ".//..\\..\\..\\Infrastructure\\Data\\numere.json";
        public NumeraService()
        {
            this.numere = Deserialize<Numera>(this.filePath);
        }
        public void AddNumera(Numera numera)
        {
            numere.Add(numera);
            Serialize<Numera>(filePath, numere);
        }
        public Numera FindNumera(int id)
        {
            return numere.Find(z => z.Id== id);
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

        public void AddEditorsRating(int numeraId, Ocena rating)
        {
            foreach (Numera numera in numere)
            {
                if (numera.Id == numeraId)
                {
                    numera.OcenaUrednika = rating;
                    break;
                }
            }
            Serialize<Numera>(filePath, numere);
        }

        public void AddUsersRating(int numeraId, Ocena rating)
        {
            foreach (Numera numera in numere)
            {
                if (numera.Id == numeraId)
                {
                    numera.OceneKorisnika.Add(rating);
                    break;
                }
            }
            Serialize<Numera>(filePath, numere);
        }
    }
}
