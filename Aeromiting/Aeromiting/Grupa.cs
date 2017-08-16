using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeromiting
{
   public class Grupa
    {
        string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        double vremeLeta;

        public double VremeLeta
        {
            get { return vremeLeta; }
            set { vremeLeta = value; }
        }
        List<Pilot> spisakPilota;

        public List<Pilot> SpisakPilota
        {
            get { return spisakPilota; }
            set { spisakPilota = value; }
        }

        public Grupa(string naziv, double vremeLeta)
        {
            this.naziv=naziv;
            this.vremeLeta=vremeLeta;
            spisakPilota = new List<Pilot>();
        }
    }
}
