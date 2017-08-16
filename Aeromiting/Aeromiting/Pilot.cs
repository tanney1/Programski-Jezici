using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeromiting
{
   public class Pilot:Osoba
    {
        string aktivnost;

        public string Aktivnost
        {
            get { return aktivnost; }
            set { aktivnost = value; }
        }
        double duzinaLeta;

        public double DuzinaLeta
        {
            get { return duzinaLeta; }
            set { duzinaLeta = value; }
        }
        Avion avion;

        public Avion Avion
        {
            get { return avion; }
            set { avion = value; }
        }

       public Pilot(string aktivnost, double duzinaLeta, Avion avion, string ime, string prezime, DateTime datumRodjenja, string zemlja):base(ime, prezime, datumRodjenja, zemlja)
       {
           this.aktivnost=aktivnost;
           this.duzinaLeta=duzinaLeta;
           this.avion=avion;
       }
    }
}
