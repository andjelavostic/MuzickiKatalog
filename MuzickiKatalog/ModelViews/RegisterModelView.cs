using MuzickiKatalog.Infrastructure.Service;
using MuzickiKatalog.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.ModelViews
{
    public class RegisterModelView
    {
        public RegisterModelView() { }
        public bool Register(string name, string lastName, string email, string password, RegistrovanKorisnikService rkS)
        {
            if (rkS.PostojiEmail(email))
            {
                return false;
            }
            RegistrovanKorisnik novi = new RegistrovanKorisnik(name, lastName, email, password);
            rkS.DodajKorisnika(novi);
            return true;
        } 
    }
}
