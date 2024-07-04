using MuzickiKatalog.Models.Items;
using MuzickiKatalog.Models.Users;
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
            recenzije.Add(recenzija);
            Serialize<Recenzija>(filePath, recenzije);
        }

        public Recenzija GetRecenzijaById(string userId, int contentId)
        {
            foreach (Recenzija recenzija in recenzije)
            {
                if (recenzija.IdKorisnik.Equals(userId) && recenzija.IdSadrzaja == contentId)
                {
                    return recenzija;
                }
            }
            return null;
        }

        public Recenzija GetEditorsReviewForContent(int contentId)
        {
            UrednikService urednikService = new UrednikService();
            foreach (Recenzija recenzija in recenzije)
            {
                if (recenzija.IdSadrzaja != contentId)
                    continue;
                else
                {
                    foreach (Urednik urednik in urednikService.GetAll())
                    {
                        if (urednik.Email.Equals(recenzija.IdKorisnik))
                            return recenzija;
                    }
                }
            }
            return null;
        }
    }
}
