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
    public class AddTrackModelView
    {
        private GlobalID idCounter;
        private string idKreatora;
        private IzvodjacService izvodjacService;
        private NumeraService numeraService;
        private RecenzijaService recenzijaService;
        public AddTrackModelView(string id)
        {
            idCounter = new GlobalID();
            idKreatora = id;
            izvodjacService = new IzvodjacService();
            numeraService = new NumeraService();
            recenzijaService = new RecenzijaService();
        }
        public bool AddTrackAdmin(string naziv, string opis, string slika, double trajanje, int idIzvodjac, List<Zanr> zanrovi)
        {
            Numera numera = new Numera(idCounter.NextId(), opis, slika, new Ocena(), new List<Ocena>(), trajanje, DateTime.Now, zanrovi, naziv, idIzvodjac, idKreatora);
            numeraService.AddNumera(numera);
            return true;
        }
        public bool AddTrackEditor(string naziv,string opis,string slika,int ocena,string review,double trajanje,int idIzvodjac,List<Zanr> zanrovi)
        {
            Ocena oc = new Ocena();
            oc.Id = idCounter.NextId();
            oc.Vrednost = ocena;
            oc.Korisnik = idKreatora;
            int idSadrzaja = idCounter.NextId();
            Numera numera = new Numera(idSadrzaja, opis, slika, oc, new List<Ocena>(), trajanje, DateTime.Now, zanrovi, naziv, idIzvodjac, idKreatora);
            numeraService.AddNumera(numera);
            Recenzija rec = new Recenzija(idCounter.NextId(), review, idSadrzaja, idKreatora);
            recenzijaService.AddRecenzija(rec);
            return true;
        }
    }
}
