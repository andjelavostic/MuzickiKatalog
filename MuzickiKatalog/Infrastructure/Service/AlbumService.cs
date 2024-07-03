using MuzickiKatalog.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class AlbumService:FileService
    {
        private List<Album> albumi;
        private string filePath= ".//..\\..\\..\\Infrastructure\\Data\\albumi.json";
        public AlbumService()
        {
            this.albumi= Deserialize<Album>(this.filePath);
        }
        public void AddAlbum(Album album)
        {
            albumi.Add(album);
            Serialize<Album>(filePath, albumi);
        }
        public override List<T> Deserialize<T>(string _filename)
        {
            return base.Deserialize<T>(_filename);
        }
        public override void Serialize<T>(string _filename, List<T> items)
        {
            base.Serialize<T>(_filename, items);
        }
        public List<Album> GetAll()
        {
            return albumi;
        }
        public Album GetByID(int id)
        {
            return albumi.FirstOrDefault(album => album.Id == id);
        }
        public void AddEditorsRating(int albumId, Ocena rating)
        {
            foreach (Album album in albumi)
            {
                if (album.Id == albumId)
                {
                    album.OcenaUrednika = rating;
                    break;
                }
            }
            Serialize<Album>(filePath, albumi);
        }

        public void AddUsersRating(int albumId, Ocena rating)
        {
            foreach (Album album in albumi)
            {
                if (album.Id == albumId)
                {
                    album.OceneKorisnika.Add(rating);
                    break;
                }
            }
            Serialize<Album>(filePath, albumi);
        }
    }
}
}
