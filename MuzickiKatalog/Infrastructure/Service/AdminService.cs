using MuzickiKatalog.Models.Items;
using MuzickiKatalog.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class AdminService:FileService
    {
        private List<Admin> admini;
        private string filePath=".//..\\..\\..\\Infrastructure\\Data\\admin.json";
        public AdminService()
        {
            this.admini = Deserialize<Admin>(this.filePath);
        }
        public override List<T> Deserialize<T>(string _filename)
        {
            return base.Deserialize<T>(_filename);
        }
        public override void Serialize<T>(string _filename, List<T> items)
        {
            base.Serialize<T>(_filename, items);
        }
        public List<Admin> GetAll()
        {
            return admini;
        }
        public void BlokiranjeKorisnika(int idKorisnik) {
            
        }
        public void KreiranjeAnkete(int period)
        {

        }
        public void UpravljanjeReklamama(int idReklama)
        {

        }
        public void PregledUrednika()
        {

        }
        public void UredjivanjePocetneStrane()
        {

        }
        public void BrisanjeRecenzija(int idRecenzija)
        {

        }
        public void DodavanjeNumere(NumeraService numera)
        {

        }
        public void DodavanjeAlbuma(Album album)
        {

        }
        public void DodavanjeIzvodjaca(Izvodjac izvodjac)
        {

        }
        public void RegistracijaUrednika(Urednik urednik)
        {

        }
        public void ZadavanjeZadatka(MuzickiSadrzaj zadatak,int idUrednika)
        {

        }
        public bool PrihvatanjeZahtevaIzmene(int idKorisnika,int idRecenzije)
        {
            return false;
        }
    }
}
