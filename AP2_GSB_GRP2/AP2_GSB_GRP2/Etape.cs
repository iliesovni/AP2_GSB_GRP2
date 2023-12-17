using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_GSB_GRP2
{
    internal class Etape
    {
        private int num;
        private string libelle;

        public Etape(int leNum, string leLibelle)
        {
            this.num = leNum;
            this.libelle = leLibelle;
        }

        public int getNum()
        {
            return this.num;
        }

        public string getLibelle()
        {
            return this.libelle;
        }

        public void setNum(int num)
        {
            this.num = num;
        }

        public void setLibelle(string libelle)
        {
            this.libelle = libelle;
        }
    }
}
