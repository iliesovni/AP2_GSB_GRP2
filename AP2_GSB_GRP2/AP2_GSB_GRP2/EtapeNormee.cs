using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_GSB_GRP2
{

        class EtapeNormee : Etape
        {
            private string norme;
            private DateTime dateNorme;

            public EtapeNormee(string norme, DateTime dateNorme, int num, string libelle) : base(num, libelle)
            {
                this.norme = norme;
                this.dateNorme = dateNorme;
            }

            public string getNorme()
            {
                return this.norme;
            }

            public DateTime getDateNorme()
            {
                return this.dateNorme;
            }

            public void setNorme(string norme)
            {
                this.norme = norme;
            }

            public void setDateNorme(DateTime dateNorme)
            {
                this.dateNorme = dateNorme;
            }
        }
}
