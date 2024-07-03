using MuzickiKatalog.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class GrupaService : FileService
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
        public void AddGrupa(Grupa grupa)
        {
            grupe.Add(grupa);
            Serialize<Grupa>(filePath, grupe);
        }
        public List<Grupa> GetAll()
        {
            return grupe;
        }
        public Grupa GetByID(int id)
        {
            return grupe.FirstOrDefault(grupa => grupa.Id == id);
        }

        public void AddEditorsRating(int grupaId, Ocena rating)
        {
            foreach (Grupa grupa in grupe)
            {
                if (grupa.Id == grupaId)
                {
                    grupa.OcenaUrednika = rating;
                    break;
                }
            }
            Serialize<Grupa>(filePath, grupe);
        }

        public void AddUsersRating(int grupaId, Ocena rating)
        {
            foreach (Grupa grupa in grupe)
            {
                if (grupa.Id == grupaId)
                {
                    grupa.OceneKorisnika.Add(rating);
                    break;
                }
            }
            Serialize<Grupa>(filePath, grupe);
        }
    }
}
