using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Zamestnanec
    {
        protected string jmeno;
        protected string prijmeni;
        protected DateTime datumNastupu;
        protected short hodinovaMzda;
        public short HodinovaMzda { get => hodinovaMzda; }
        protected short odpracHodiny;

        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNastupu, short hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.hodinovaMzda = hodinovaMzda;
            odpracHodiny = 0;
        }

        public virtual int PocetDni()
        {
            return (int)(DateTime.Now - datumNastupu).TotalDays;
        }

        public virtual void OdpracujHodiny(short hodiny)
        {
            odpracHodiny += hodiny;
        }

        public virtual int VypocitejMzdu()
        {
            return hodinovaMzda * odpracHodiny;
        }

        public virtual string Vypis()
        {
            return String.Format("Jmeno: {0}\nPřijmení: {1}\nDatum nástupu: {2}\nHodinová mzda: {3}\nOdpracované hodiny: {4}\nZatím neproplacená mzda: {5}",
                jmeno, prijmeni, datumNastupu.ToString("d"), HodinovaMzda, odpracHodiny, VypocitejMzdu());
        }
    }
}