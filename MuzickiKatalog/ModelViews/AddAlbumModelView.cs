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
    public class AddAlbumModelView
    {
        private GlobalID idCounter;
        private string idKreatora;
        private IzvodjacService izvodjacService;
        private NumeraService numeraService;
        private AlbumService albumService;
        private RecenzijaService recenzijaService;
        public AddAlbumModelView(string id)
        {
            idCounter = new GlobalID();
            idKreatora = id;
            izvodjacService = new IzvodjacService();
            numeraService = new NumeraService();
            albumService = new AlbumService();
            recenzijaService = new RecenzijaService();
        }
        public bool AddAlbumAdmin(string opis, string slika,List<Numera> numere,TipAlbuma tip,string izdavacka,List<Zanr> zanrovi,string naziv,int idIzvodjac)
        {
            Album album = new Album(idCounter.NextId(), opis, slika, new Ocena(), new List<Ocena>(), numere, tip, izdavacka, DateTime.Now, zanrovi, naziv, idIzvodjac, idKreatora);
            albumService.AddAlbum(album);
            return true;
        }
        public bool AddAlbumEditor(string opis, string slika, List<Numera> numere, TipAlbuma tip, string izdavacka, List<Zanr> zanrovi, string naziv, int idIzvodjac,string review,int ocena)
        {
            Ocena oc = new Ocena();
            oc.Id = idCounter.NextId();
            oc.Vrednost = ocena;
            oc.Korisnik = idKreatora;
            int idSadrzaja = idCounter.NextId();
            Album album = new Album(idSadrzaja, opis, slika, oc, new List<Ocena>(), numere, tip, izdavacka, DateTime.Now, zanrovi, naziv, idIzvodjac, idKreatora);
            albumService.AddAlbum(album);
            Recenzija rec = new Recenzija(idCounter.NextId(), review, idSadrzaja, idKreatora);
            recenzijaService.AddRecenzija(rec);
            return true;
        }
    }
}
