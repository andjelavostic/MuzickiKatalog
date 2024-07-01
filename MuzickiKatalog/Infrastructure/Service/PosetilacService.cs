using MuzickiKatalog.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    internal class PosetilacService : FileService
    {
        private List<Posetilac> posetioci;
        private string filePath;
        public PosetilacService()
        {
            this.posetioci = Deserialize<Posetilac>(this.filePath);
        }
        public override List<T> Deserialize<T>(string _filename)
        {
            return base.Deserialize<T>(_filename);
        }
        public override void Serialize<T>(string _filename, List<T> items)
        {
            base.Serialize<T>(_filename, items);
        }
        public Boolean Registracija(String ime, String prezime, String email, String lozinka, RegistrovanKorisnikService registrovaniKorisnici)
        {
            if (registrovaniKorisnici.PostojiEmail(email))
            {
                return false;
            }
            RegistrovanKorisnik noviKorisnik = new RegistrovanKorisnik(ime, prezime, email, lozinka);
            registrovaniKorisnici.DodajKorisnika(noviKorisnik);
            return true;
        }
        public void PregledSadrzaja()
        {

        }
        public void PretragaSadrzaja()
        {

        }
        public void Stream()
        {

        }
        public void LogIn(String email, string lozinka)
        {
            //posjetilac ima profil pa se registruje
        }
    }
}
