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
        public List<Numera> SearchNumere(String input, NumeraService nS)
        {
            List<Numera> numere = new List<Numera>();
            foreach (Numera n in nS.GetAll())
            {
                if (n.Naziv.ToLower() == input.ToLower())
                {
                    numere.Add(n);
                }
            }
            return numere;

        }
        public List<Album> SearchAlbumi(String input, AlbumService aS)
        {
            List<Album> albumi = new List<Album>();
            foreach (Album a in aS.GetAll())
            {
                if (a.Naziv.ToLower() == input.ToLower())
                {
                    albumi.Add(a);
                }
            }
            return albumi;

        }
        public List<Grupa> SearchGrupe(String input, GrupaService gS)
        {
            List<Grupa> grupe = new List<Grupa>();
            foreach (Grupa g in gS.GetAll())
            {
                if (g.Naziv.ToLower() == input.ToLower())
                {
                    grupe.Add(g);
                }
            }
            return grupe;

        }
        public List<Izvodjac> SearchIzvodjaci(String input, IzvodjacService iS)
        {
            List<Izvodjac> izvodjaci = new List<Izvodjac>();
            foreach (Izvodjac i in iS.GetAll())
            {
                if (i.Ime.ToLower() == input.ToLower() || i.Prezime.ToLower() == input.ToLower())
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
