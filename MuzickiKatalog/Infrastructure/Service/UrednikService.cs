using MuzickiKatalog.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Infrastructure.Service
{
    public class UrednikService : FileService
    {
        private List<Urednik> urednici;
        private string filePath = ".//..\\..\\..\\Infrastructure\\Data\\urednici.json";
        public UrednikService()
        {
            this.urednici = Deserialize<Urednik>(this.filePath);
        }
        public override List<T> Deserialize<T>(string _filename)
        {
            return base.Deserialize<T>(_filename);
        }
        public override void Serialize<T>(string _filename, List<T> items)
        {
            base.Serialize<T>(_filename, items);
        }
        public List<Urednik> GetAll()
        {
            return urednici;
        }
        public Urednik GetById(string email)
        {
            return GetAll().Find(k => k.Email == email);
        }
        public void dodavanjeAlbuma()
        { 
        
        }
        public void ocenjivanje()
        {

        }
        public void pisanjeRecenzije()
        {

        }
        public void dodavanjeNumere()
        {

        }
        public void dodavanjeIzvodjaca()
        {

        }
        public void ucestvovanjeUAnketi()
        {

        }
    }
}
