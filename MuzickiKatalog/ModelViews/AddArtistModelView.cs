using MuzickiKatalog.Infrastructure.Service;
using MuzickiKatalog.Models;
using MuzickiKatalog.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.ModelViews
{
    public class AddArtistModelView
    {

        private GlobalID idCounter;
        private string idKreatora;
        private IzvodjacService izvodjacService;
        private RecenzijaService recenzijaService;
        public AddArtistModelView(string id)
        {
            idCounter = new GlobalID();
            idKreatora = id;
            izvodjacService = new IzvodjacService();
            recenzijaService = new RecenzijaService();
        }
        public bool AddArtistAdmin(string desc,string name,string lastName,List<Zanr> zanrovi,string img)
        {
            Izvodjac izvodjac = new Izvodjac(idCounter.NextId(), desc, img, new Ocena(), new List<Ocena>(), name, lastName, zanrovi, idKreatora);
            izvodjacService.AddIzvodjac(izvodjac);
            return true;
        }
        public bool AddArtistEditor(string desc, string name, string lastName, List<Zanr> zanrovi, string img,string rewiew,int ocena)
        {
            Ocena oc = new Ocena();
            oc.Id=idCounter.NextId();
            oc.Vrednost = ocena;
            oc.Korisnik = idKreatora;
            int idSadrzaja = idCounter.NextId();
            Izvodjac izvodjac = new Izvodjac(idSadrzaja, desc, img, oc, new List<Ocena>(), name, lastName, zanrovi, idKreatora);
            izvodjacService.AddIzvodjac(izvodjac);
            Recenzija rec = new Recenzija(idCounter.NextId(), rewiew, idSadrzaja, idKreatora);
            recenzijaService.AddRecenzija(rec);
            return true;
        }
    }
}
