﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models.Users
{
    public class Admin : Korisnik
    {
        public Admin(string ime, string prezime, string email, string lozinka):base(ime, prezime, email, lozinka)
        {
        }
    }
}