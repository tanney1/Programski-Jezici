using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aeromiting;

namespace Konzolna
{
    class Aeromiting
    {
        string zemlja;

        public string Zemlja
        {
            get { return zemlja; }
            set { zemlja = value; }
        }
        List<Grupa> spisakGrupa;

        public List<Grupa> SpisakGrupa
        {
            get { return spisakGrupa; }
            set { spisakGrupa = value; }
        }
        double ukupnoVremeLeta;

        public double UkupnoVremeLeta
        {
            get { return ukupnoVremeLeta; }
            set { ukupnoVremeLeta = value; }
        }

        public Aeromiting(string zemlja, double ukupnoVremeLeta)
        {
            this.zemlja=zemlja;
            this.spisakGrupa=spisakGrupa;
            spisakGrupa = new List<Grupa>();

        }

        static void Main(string[] args)
        {
        }
    }
}
