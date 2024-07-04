using MuzickiKatalog.Infrastructure.Service;
using MuzickiKatalog.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.ModelViews
{
    public class SearchModelView
    {
        public SearchModelView() { }

        public List<Numera> SearchFullNumere(string input, string genre, NumeraService nS)
        {
            List<Numera> numere = new List<Numera>();
            foreach (Numera n in nS.GetAll())
            {
                if (n.Naziv.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    numere.Add(n);
                    continue;
                }
                foreach (Zanr z in n.Zanrovi)
                {
                    if (z.Naziv.IndexOf(genre, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        numere.Add(n);
                        break;
                    }
                }
            }
            return numere;
        }
        public List<Album> SearchFullAlbumi(string input, string genre, AlbumService aS)
        {
            List<Album> albumi = new List<Album>();
            foreach (Album a in aS.GetAll())
            {
                if (a.Naziv.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    albumi.Add(a);
                    continue;
                }
                foreach (Zanr z in a.Zanrovi)
                {
                    if (z.Naziv.IndexOf(genre, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        albumi.Add(a);
                        break;
                    }
                }
            }
            return albumi;
        }
        public List<Izvodjac> SearchFullIzvodjaci(string input, string genre, IzvodjacService iS)
        {
            List<Izvodjac> izvodjaci = new List<Izvodjac>();
            foreach (Izvodjac i in iS.GetAll())
            {
                if (i.Ime.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0 || i.Prezime.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    izvodjaci.Add(i);
                    continue;
                }
                foreach (Zanr z in i.Zanrovi)
                {
                    if (z.Naziv.IndexOf(genre, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        izvodjaci.Add(i);
                        break;
                    }
                }
            }
            return izvodjaci;
        }
        public List<Grupa> SearchFullGrupe(string input, string genre, GrupaService gS)
        {
            List<Grupa> grupe = new List<Grupa>();
            foreach (Grupa g in gS.GetAll())
            {
                if (g.Naziv.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    grupe.Add(g);
                    continue;
                }
                foreach (Zanr z in g.Zanrovi)
                {
                    if (z.Naziv.IndexOf(genre, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        grupe.Add(g);
                        break;
                    }
                }
            }
            return grupe;
        }
        public List<Numera> SearchGenreNumere(String input, NumeraService nS)
        {
            List<Numera> numere = new List<Numera>();
            foreach (Numera n in nS.GetAll())
            {
                foreach(Zanr z in n.Zanrovi)
                {
                    if(z.Naziv.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        numere.Add(n);
                        break;
                    }
                }
            }
            return numere;

        }
        public List<Album> SearchGenreAlbumi(String input, AlbumService aS)
        {
            List<Album> albumi = new List<Album>();
            foreach (Album a in aS.GetAll())
            {
                foreach (Zanr z in a.Zanrovi)
                {
                    if (z.Naziv.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        albumi.Add(a);
                        break;
                    }
                }
            }
            return albumi;

        }
        public List<Izvodjac> SearchGenreIzvodjaci(String input, IzvodjacService iS)
        {
            List<Izvodjac> izvodjaci = new List<Izvodjac>();
            foreach (Izvodjac i in iS.GetAll())
            {
                foreach (Zanr z in i.Zanrovi)
                {
                    if (z.Naziv.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        izvodjaci.Add(i);
                        break;
                    }
                }
            }
            return izvodjaci;

        }
        public List<Grupa> SearchGenreGrupe(String input, GrupaService gS)
        {
            List<Grupa> grupe = new List<Grupa>();
            foreach (Grupa g in gS.GetAll())
            {
                foreach (Zanr z in g.Zanrovi)
                {
                    if (z.Naziv.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        grupe.Add(g);
                        break;
                    }
                }
            }
            return grupe;

        }
        public List<Numera> SearchNumere(String input, NumeraService nS)
        {
            List<Numera> numere = new List<Numera>();
            foreach (Numera n in nS.GetAll())
            {
                if (n.Naziv.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    numere.Add(n);
                }
            }
            return numere;

        }
        public List<Album> SearchAlbumi(string input, AlbumService aS)
        {
            List<Album> albumi = new List<Album>();
            foreach (Album a in aS.GetAll())
            {
                if (a.Naziv.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    albumi.Add(a);
                }
            }
            return albumi;
        }

        public List<Grupa> SearchGrupe(string input, GrupaService gS)
        {
            List<Grupa> grupe = new List<Grupa>();
            foreach (Grupa g in gS.GetAll())
            {
                if (g.Naziv.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    grupe.Add(g);
                }
            }
            return grupe;
        }

        public List<Izvodjac> SearchIzvodjaci(string input, IzvodjacService iS)
        {
            List<Izvodjac> izvodjaci = new List<Izvodjac>();
            foreach (Izvodjac i in iS.GetAll())
            {
                if (i.Ime.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0 || i.Prezime.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    izvodjaci.Add(i);
                }
            }
            return izvodjaci;
        }
        public bool SearchIzvodjac(int id, IzvodjacService iS)
        {
            if(iS.GetByID(id) != null)
            {
                return true;
            }
            return false;
        }
        public bool SearchNumera(int id, NumeraService nS)
        {
            if (nS.GetByID(id) != null)
            {
                return true;
            }
            return false;
        }
        public bool SearchAlbum(int id, AlbumService aS)
        {
            if (aS.GetByID(id) != null)
            {
                return true;
            }
            return false;
        }
        public bool SearchGrupa(int id, GrupaService gS)
        {
            if (gS.GetByID(id) != null)
            {
                return true;
            }
            return false;
        }
        public dynamic SearchObject(int id, AlbumService aS, GrupaService gS, IzvodjacService iS, NumeraService nS)
        {
            if (SearchAlbum(id, aS))
            {
                return aS.GetByID(id);
            }
            else if(SearchGrupa(id, gS))
            {
                return gS.GetByID(id);

            }else if(SearchIzvodjac(id, iS))
            {
                return iS.GetByID(id);
            }
            else
            {
                return nS.GetByID(id);
            }
            
        }
    }
}
