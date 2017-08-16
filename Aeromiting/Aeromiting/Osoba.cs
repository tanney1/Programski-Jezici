using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeromiting
{
   public class Osoba
    {
        string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        DateTime datumRodjenja;

        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }
        string zemlja;

        public string Zemlja
        {
            get { return zemlja; }
            set { zemlja = value; }
        }

       public Osoba(string ime, string prezime, DateTime datumRodjenja, string zemlja)
       {
           this.ime = ime;
           this.prezime=prezime;
           this.datumRodjenja=datumRodjenja;
           this.zemlja=zemlja;
       }
    }
}
