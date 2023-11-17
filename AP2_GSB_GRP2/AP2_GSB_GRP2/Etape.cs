using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_GSB_GRP2
{
    internal class Etape
    {
        // attributs de la classe
        private int etp_num;
        private string etp_libelle;

        // constructeur
        public Etape(int leNum, string leLibelle)
        {
            this.etp_num = leNum;
            this.etp_libelle = leLibelle;
        }

        // Mutateurs, Accesseurs

        public int getLeNumEtape()
        {
            return this.etp_num;
        }

        public string getLeLibelleEtape()
        {
            return this.etp_libelle;
        }
    }
}
