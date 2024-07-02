using MuzickiKatalog.Models.Items;
using MuzickiKatalog.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class RegistrovanKorisnikService : FileService
    {
        private List<RegistrovanKorisnik> korisnici;
        private string filePath = ".//..\\..\\..\\Infrastructure\\Data\\korisnici.json";
        public RegistrovanKorisnikService()
        {
            this.korisnici = Deserialize<RegistrovanKorisnik>(this.filePath);
        }
        public override List<T> Deserialize<T>(string _filename)
        {
            return base.Deserialize<T>(_filename);
        }
        public override void Serialize<T>(string _filename, List<T> items)
        {
            base.Serialize<T>(_filename, items);
        }
        public List<RegistrovanKorisnik> GetAll()
        {
            return korisnici;
        }
        public bool PostojiEmail(string zadaniEmail)
        {
            return GetAll().Any(k => k.Email == zadaniEmail);
        }
        public void DodajKorisnika(RegistrovanKorisnik noviKorisnik)
        {
            korisnici.Add(noviKorisnik);
            Serialize(filePath, korisnici);
        }
        public void Stream(NumeraService numera)
        {

        }
        public void DodavanjeFavorita(Sadrzaj sadrzaj)
        {

        }
        public void Download(Sadrzaj sadrzaj)
        {

        }
        public void BrisanjeNaloga()
        {

        }
        public void DavanjeOcena(Sadrzaj sadrzaj)
        {

        }
        public void PisanjeRecenzija(Sadrzaj sadrzaj)
        {

        }
        public void UcestvovanjeUAnketi()
        {

        }
        public void ZahtevIzmeneRecenzije(Recenzija recenzija)
        {

        }

    }
}
