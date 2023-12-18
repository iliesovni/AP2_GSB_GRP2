using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_GSB_GRP2
{
    internal class Workflow
    {
        private DateTime dateDecision;
        private Etape uneEtape;
        private Decision uneDecision;

        public Workflow(DateTime laDateDecision, Etape lEtape, Decision laDecision)
        {
            this.dateDecision = laDateDecision;
            this.uneEtape = lEtape;
            this.uneDecision = laDecision;
        }

        public DateTime getDateDecision()
        {
            return this.dateDecision;
        }

        public Etape getEtape()
        {
            return this.uneEtape;
        }

        public Decision getDecision()
        {
            return this.uneDecision;
        }

        public void setDateDecision(DateTime laDateDecision)
        {
            this.dateDecision = laDateDecision;
        }

        public void setEtape(Etape lEtape)
        {
            this.uneEtape = lEtape;
        }

        public void setDecision(Decision laDecision)
        {
            this.uneDecision = laDecision;
        }
    }
}
