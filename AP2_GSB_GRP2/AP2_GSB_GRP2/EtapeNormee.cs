using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_GSB_GRP2
{
    internal class EtapeNormee
    {
        // attributs de la classe
        private int etp_norme;
        private string etp_date_norme_date;

        // constructeur
        public Etape(int laNorme, string ladateNorme)
        {
            this.etp_norme = laNorme;
            this.etp_date_norme_date = ladateNorme;
        }
    }
}
