using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_GSB_GRP2
{
    internal class Decision
    {
        private int id;
        private string libelle;

        public Decision(int leId, string leLibelle)
        {
            this.id = leId;
            this.libelle = leLibelle;
        }

        public int getLeId()
        {
            return this.id;
        }

        public string getLeLibelle()
        {
            return this.libelle;
        }

        public void setLeId(int leId)
        {
            this.id = leId;
        }

        public void setLeLibelle(string leLibelle)
        {
            this.libelle = leLibelle;
        }
    }
}
