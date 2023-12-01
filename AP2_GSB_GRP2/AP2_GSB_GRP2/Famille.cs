using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AP2_GSB_GRP2
{
    internal class Famille
    {

        private string code;
        private string libelle;

        //constructeur
        public Famille(string leCode, string leLibelle)
        {
            this.code = leCode;
            this.libelle = leLibelle;
        }

        //accesseurs & mutateurs

        public string getCode() { return this.code; }

        public string getLibelle() {  return this.libelle; }

        public void setCode(string leCode) { this.code = leCode;}

        public void setLibelle(string leLibelle) { this.libelle = leLibelle; }

    }
}
