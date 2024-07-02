using MuzickiKatalog.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class KorisnikService
    {
        private RegistrovanKorisnikService registrovanKorisnik;
        private AdminService admin;
        private UrednikService urednik;
        public Korisnik Prijava(string email, string lozinka)
        {
            List<RegistrovanKorisnik> korisnici = registrovanKorisnik.GetAll();
            List<Admin> admini = admin.GetAll();
            List<Urednik> urednici = urednik.GetAll();
            foreach (RegistrovanKorisnik reg in korisnici)
            {
                if (email == reg.Email && lozinka == reg.Lozinka)
                {
                    reg.Uloga = "korisnik";
                    return reg;
                }
            }
            foreach (Admin reg in admini)
            {
                if (email == reg.Email && lozinka == reg.Lozinka)
                {
                    reg.Uloga = "admin";
                    return reg;
                }
            }
            foreach (Urednik reg in urednici)
            {
                if (email == reg.Email && lozinka == reg.Lozinka)
                {
                    reg.Uloga = "urednik";
                    return reg;
                }
            }
            return null;
        }
        public void PregledSadrzaja()
        {

        }
        public void PretragaSadrzaja()
        {

        }
    }
}
