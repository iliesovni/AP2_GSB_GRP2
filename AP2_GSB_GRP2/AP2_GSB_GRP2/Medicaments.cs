using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_GSB_GRP2
{
    internal class Medicaments
    {
        // attributs de la classe
        private string depotLegal;
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreIndications;
        private string amm;
        private int derniereEtape;
        private char codeFamille;
        private List<Workflow> lesEtapes;


        // constructeur
        public Medicaments(string leDepotLegal, string leNomCommercial, string laComposition, string lesEffets, string lesContreIndications,
            string leAmm, int laDerniereEtape, char leCodeFamille)
        {
            this.depotLegal = leDepotLegal;
            this.nomCommercial = leNomCommercial;
            this.composition = laComposition;
            this.effets = lesEffets;
            this.contreIndications = lesContreIndications;
            this.amm = leAmm;
            this.derniereEtape = laDerniereEtape;
            this.codeFamille = leCodeFamille;
            this.lesEtapes = new List<Workflow>();

        }

        // Mutateurs, Accesseurs

        public string getleDepotLegal()
        {
            return this.depotLegal;
        }

        public string getLeNomCommercial()
        {
            return this.nomCommercial;
        }

        public string getLaComposition()
        {
            return this.composition;
        }

        public string getLesEffets()
        {
            return this.effets;
        }

        public string getLesContreIndications()
        {
            return this.contreIndications;
        }

        public string getAmm()
        {
            return this.amm;
        }

        public int getLaDerniereEtape()
        {
            return this.derniereEtape;
        }

        public string getLeCodeFamille()
        {
            return this.codeFamille;
        }
        public List<Workflow> getLesEtapes()
        {
            return this.lesEtapes;
        }

        public void setDepotLegal(string leDepotLegal)
        {
            this.depotLegal = leDepotLegal;
        }

        public void setNomCommercial(string leNomCommercial)
        {
            this.nomCommercial = leNomCommercial;
        }

        public void setComposition(string laComposition)
        {
            this.composition = laComposition;
        }

        public void setLesEffets(string lesEffets)
        {
            this.effets = lesEffets;
        }

        public void setLesContreIndications(string lesContreIndications)
        {
            this.contreIndications = lesContreIndications;
        }

        public void setAmm(string leAmm)
        {
            this.amm = leAmm;
        }

        public void setDerniereEtape(int laDerniereEtape)
        {
            this.derniereEtape = laDerniereEtape;
        }

        public void setCodeFamille(char leCodeFamille)
        {
            this.codeFamille = leCodeFamille;
        }


    }
}
