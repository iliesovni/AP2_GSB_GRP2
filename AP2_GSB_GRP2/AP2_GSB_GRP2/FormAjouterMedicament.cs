using System.Data.SqlClient;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AP2_GSB_GRP2
{
    public partial class FormAjouterMedicament : Form
    {
        public FormAjouterMedicament()
        {
            InitializeComponent();
        }

        private void FormAjouterMedicament_Load(object sender, EventArgs e)
        {
            
        }

        public static bool ajoutMedicament(string depot_legal, string nom_commercial, string composition, string effets, string contre_indications, string med_Amm, string fam_Code ,SqlConnection con)
        {
            bool ok = false;

            using (SqlCommand requete = new SqlCommand("prc_ajout_medicament", con))
            {
                requete.CommandType = System.Data.CommandType.StoredProcedure;

                // Ajouter les paramètres à la procédure stockée
                SqlParameter paramDepot_Legal = new SqlParameter("@depot_legal", System.Data.SqlDbType.NVarChar, 200);
                paramDepot_Legal.Value = depot_legal;

                SqlParameter paramNomCommercial = new SqlParameter("@nom_commercial", System.Data.SqlDbType.NVarChar, 200);
                paramNomCommercial.Value = nom_commercial;

                SqlParameter paramComposition = new SqlParameter("@composition", System.Data.SqlDbType.NVarChar, 200);
                paramComposition.Value = composition;

                SqlParameter paramEffets = new SqlParameter("@effets", System.Data.SqlDbType.NVarChar, 200);
                paramEffets.Value = effets;

                SqlParameter paramContreIndications = new SqlParameter("@contre_indications", System.Data.SqlDbType.NVarChar, 200);
                paramContreIndications.Value = contre_indications;

                SqlParameter paramMedAmm = new SqlParameter("@med_amm", System.Data.SqlDbType.NVarChar, 200);
                paramMedAmm.Value = med_Amm;

                SqlParameter paramFamCode = new SqlParameter("@fam_code_medicament", System.Data.SqlDbType.NVarChar, 200);
                paramFamCode.Value = fam_Code;

                requete.Parameters.Add(paramDepot_Legal);
                requete.Parameters.Add(paramNomCommercial);
                requete.Parameters.Add(paramComposition);
                requete.Parameters.Add(paramEffets);
                requete.Parameters.Add(paramContreIndications);
                requete.Parameters.Add(paramMedAmm);
                requete.Parameters.Add(paramFamCode);



                try
                {
                    requete.ExecuteNonQuery();
                    ok = true;
                    MessageBox.Show("Médicament ajouté avec succès ! ");

                }
                catch(Exception error)
                {
                    ok = false;
                    MessageBox.Show("Erreur lors de la saisie du médicament", error.Message);

                }

                return ok;

            }


        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Chaîne de connexion à la BDD
            string connexion = "Data Source = BTS2022-24\\SQLEXPRESS01; Initial Catalog = AP2-GP2; Integrated Security=true";

            // Initialisation d'une connexion à la BDD à partir de la chaîne de connexion
            SqlConnection con = new SqlConnection(connexion);

            // Ouverture de la connexion à la BDD
            con.Open();

            
            ajoutMedicament(tbFamille.Text.ToString(), tbDepotLegal.Text.ToString(), tbNonCommercial.Text.ToString(), tbComposition.Text.ToString(), tbEffets.Text.ToString(), tbContreIndications.Text.ToString(), tbPrixEchantillon.Text.ToString(), con);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}