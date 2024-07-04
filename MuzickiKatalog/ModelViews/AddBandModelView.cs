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
    public class AddBandModelView
    {
        private GlobalID idCounter;
        private string idKreatora;
        private IzvodjacService izvodjacService;
        private GrupaService grupaService;
        private RecenzijaService recenzijaService;
        public AddBandModelView(string id)
        {
            idCounter = new GlobalID();
            idKreatora = id;
            izvodjacService = new IzvodjacService();
            recenzijaService = new RecenzijaService();
            grupaService = new GrupaService();
        }
        public bool AddBandAdmin(string desc, string name, string img, List<Zanr> zanrovi,DateTime date,List<Izvodjac> izvodaci)
        {
            Grupa g = new Grupa(idCounter.NextId(), img, desc, new Ocena(), new List<Ocena>(),date, true, izvodaci, name, zanrovi, idKreatora);
            grupaService.AddGrupa(g);
            return true;
        }
        public bool AddBandEditor(string desc, string name, string img, List<Zanr> zanrovi, DateTime date, List<Izvodjac> izvodaci, string rewiew, int ocena)
        {
            Ocena oc = new Ocena();
            oc.Id = idCounter.NextId();
            oc.Vrednost = ocena;
            oc.Korisnik = idKreatora;
            int idSadrzaja = idCounter.NextId();
            Grupa g = new Grupa(idSadrzaja, img, desc,oc, new List<Ocena>(), date, true, izvodaci, name, zanrovi, idKreatora);
            grupaService.AddGrupa(g);
            Recenzija rec = new Recenzija(idCounter.NextId(), rewiew, idSadrzaja, idKreatora);
            recenzijaService.AddRecenzija(rec);
            return true;
        }
    }
}
