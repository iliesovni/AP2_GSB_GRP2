using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public List<Etape> getLesEtapes(SqlConnection con)
        {
            List<Etape> lesEtapes = new List<Etape>();

            {

                SqlCommand maRequete = new SqlCommand("prc_getEtapes", con);
                maRequete.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader SqlDataRead = maRequete.ExecuteReader())
                {
                    while (SqlDataRead.Read())
                    {
                        int num = Convert.ToInt32(SqlDataRead["ETP_NUM"]);
                        string libelle = SqlDataRead["ETP_LIBELLE"].ToString();
                        string norme = SqlDataRead["ETP_NORME"].ToString();
                        DateTime dateNorme = DateTime.MaxValue;

                        if (SqlDataRead["ETP_DATE_NORME"].ToString() != "")
                        {
                            dateNorme = Convert.ToDateTime(SqlDataRead["ETP_DATE_NORME"]);
                        }

                        if (norme == "" && dateNorme == DateTime.MaxValue)
                        {
                            lesEtapes.Add(new Etape(num, libelle));
                        }
                        else
                        {
                            lesEtapes.Add(new EtapeNormee(norme, dateNorme, num, libelle));
                        }
                    }
                }
            }

            return lesEtapes;
        }

    }
}