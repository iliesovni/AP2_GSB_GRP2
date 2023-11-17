using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_GSB_GRP2
{
    internal class EtapeNormee : Etape
    {
        // attributs de la classe
        private int etp_norme;
        private string etp_date_norme;

        // constructeur
        public Etape(int laNorme, string ladateNorme) : base(leNum, leLibelle)
        {
            this.etp_norme = laNorme;
            this.etp_date_norme = ladateNorme;
        }

        // Mutateurs, Accesseurs
        public int getLaNorme()
        {
            return this.etp_norme;
        }

        public string getLaDateNorme()
        {
            return this.etp_date_norme;
        }
    }
}
