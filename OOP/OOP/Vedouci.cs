using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Vedouci : Zamestnanec
    {
        private short priplatekZaVedeni;
        private string titul;
        public Vedouci(string jmeno, string prijmeni, DateTime datumNastupu, short hodinovaMzda, short priplatekZaVedeni, string titul) : base(jmeno,prijmeni,datumNastupu, hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.hodinovaMzda = hodinovaMzda;
            this.priplatekZaVedeni = priplatekZaVedeni;
            this.titul = titul;
            odpracHodiny = 0;
        }

        public override int VypocitejMzdu()
        {
            return base.VypocitejMzdu() + (odpracHodiny * priplatekZaVedeni);
        }

        public override string Vypis()
        {
            return String.Format("Titul: {6}\nJmeno: {0}\nPřijmení: {1}\nDatum nástupu: {2}\nHodinová mzda: {3}\nPříplatek za vedení: {7}\nOdpracované hodiny: {4}\nZatím neproplacená mzda: {5}",
                jmeno, prijmeni, datumNastupu.ToString("d"), HodinovaMzda, odpracHodiny, VypocitejMzdu(),titul,priplatekZaVedeni);
        }
    }
}
