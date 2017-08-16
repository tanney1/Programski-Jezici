using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeromiting
{
    public enum Tip
    { 
        Borbeni, 
        Skolski,
        Helikopter,
        Drugo
    }
    public class Avion
    {
        Tip tip;


        public Tip Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        string zemlja;

        public string Zemlja
        {
            get { return zemlja; }
            set { zemlja = value; }
        }

        public Avion(Tip tip, string naziv, string zemlja)
        {
            this.tip = tip;
            this.naziv = naziv;
            this.zemlja = zemlja;

        }

    }
}
