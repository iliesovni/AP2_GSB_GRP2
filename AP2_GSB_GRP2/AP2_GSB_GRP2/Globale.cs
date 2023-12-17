using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_GSB_GRP2
{
    static class Globale
    {
        public static Dictionary<string, Famille> lesFamilles = new Dictionary<string, Famille>(); // clé du dico : code famille
        public static Dictionary<string, Medicament> lesMedicaments = new Dictionary<string, Medicament>(); // clé du dico : dépôt légal
        public static List<Etape> lesEtapes;
        //public static List<Decision> lesDecisions;

    }
}
