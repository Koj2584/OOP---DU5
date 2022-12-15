using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    class Veteran : Atlet
    {
        private short vek;

        public Veteran(string jmeno, short vek) : base(jmeno)
        {
            this.vek = vek;
        }

        public new void Behej(int pocetKm)
        {
            base.Behej(pocetKm);
            if (vek >= 30)
            {
                short vekKrat = (short)(vek % 10);
                if (unava + pocetKm * vekKrat < 200)
                {
                    unava += pocetKm * (vek % 10);
                }
                else
                {
                    MessageBox.Show("běžec je moc unavený!!");
                    unava = 200;
                }
            }
        }

        public new void Spi(int pocetHodin)
        {
            short vekKrat = (short)((vek % 10) - 2);
            if (vek < 30)
                vekKrat = 0;
            base.Spi(pocetHodin, 100 - 10 * vekKrat);
        }

        public new int ZjistitUnavu()
        {
            return base.ZjistitUnavu();
        }
    }
}
