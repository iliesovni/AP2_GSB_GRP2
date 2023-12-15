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
            /*string connexion = "Data Source = BTS2022-24\\SQLEXPRESS01; Initial Catalog = AP2-GP2; Integrated Security=true";
            SqlConnection con = new SqlConnection(connexion);
            con.Open();
            string requete = "";
            SqlCommand commande = new SqlCommand(requete, con);
            SqlDataReader reader = commande.ExecuteReader();

            
            con.Close(); // Fermer la connexion après utilisation

            */
          
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static bool ajoutMedicament(string famille, string depot_legal, string nom_commercial, string composition, string effets, string contre_indications, float prix_echantillon)
        {
            // Créer une instance de l'objet SqlCommand pour exécuter une procédure stockée dans une BDD
            using (SqlCommand requete = new SqlCommand("prc_ajout_medicament"))
            {
                // Indiquer que la commande est une procédure stockée
                requete.CommandType = System.Data.CommandType.StoredProcedure;

                // Ajouter les paramètres à la procédure stockée
                SqlParameter paramFamille = new SqlParameter("@famille", System.Data.SqlDbType.NVarChar, 50);
                paramFamille.Value = famille;

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

                SqlParameter paramPrixEchantillon = new SqlParameter("@prix_echantillon", System.Data.SqlDbType.Float);
                paramPrixEchantillon.Value = prix_echantillon;

                // Ajouter les paramètres à la commande
                requete.Parameters.Add(paramFamille);
                requete.Parameters.Add(paramDepot_Legal);
                requete.Parameters.Add(paramNomCommercial);
                requete.Parameters.Add(paramComposition);
                requete.Parameters.Add(paramEffets);
                requete.Parameters.Add(paramContreIndications);
                requete.Parameters.Add(paramPrixEchantillon);

                // Executer la commande
                SqlDataReader SqlDataRead = requete.ExecuteNonQuery();

            }
        }

    }
}