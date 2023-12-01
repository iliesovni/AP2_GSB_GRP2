using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_GSB_GRP2
{
    internal class Medicament
    {

        public string depotLegal;
        public string nomCommercial;
        public string composition;
        public string effets;
        public string contreIndic;
        public string amm;

        //constructeur
        public Medicament(string leDepotLegal, string leNomCommercial, string laComposition, string lesEffets, string leContreIndic, string leAmm)
        {
            this.depotLegal = leDepotLegal;
            this.nomCommercial = leNomCommercial;
            this.composition = laComposition;
            this.effets = lesEffets;
            this.contreIndic = leContreIndic;
            this.amm = leAmm;
        }

        //accesseurs & mutateurs

        public string getDepotLegal() { return this.depotLegal; }

        public string getNomCommercial() {  return this.nomCommercial; }

        public string getComposition() {  return this.composition; }

        public string getEffets() { return this.effets; }

        public string getContreIndic() {  return this.contreIndic; }

        public string getAmm() { return this.amm; }

        public void setDepotLegal(string leDepotLegal) { this.depotLegal = leDepotLegal; }

        public void setNomCommercial(string leNomCommercial) { this.nomCommercial = leNomCommercial; }

        public void setComposition(string laComposition) { this.composition = laComposition; }

        public void setEffets(string lesEffets) { this.effets = lesEffets; }

        public void setContreIndic(string leContreIndic) { this.contreIndic = leContreIndic; }

        public void setAmm(string leAmm) { this.amm = leAmm; }
    }
}