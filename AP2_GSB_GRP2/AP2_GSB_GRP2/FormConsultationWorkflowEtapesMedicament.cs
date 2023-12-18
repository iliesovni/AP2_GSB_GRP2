using System.Data.SqlClient;

namespace AP2_GSB_GRP2
{
    public partial class FormConsultationWorkflowEtapesMedicament : Form
    {
        public FormConsultationWorkflowEtapesMedicament()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void FormConsultationWorkflowEtapesMedicament_Load(object sender, EventArgs e)
        {
            //Globale.lesMedicaments.Clear();

            // Cha�ne de connexion à la BDD
            string connexion = "Data Source = DESKTOP-41R7HMR\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=true;User Id=DESKTOP-41R7HMR\\iliesjaaj;MultipleActiveResultSets=True";
            // Initialisation d'une connexion � la BDD � partir de la cha�ne de connexion
            SqlConnection con = new SqlConnection(connexion);
            // Ouverture de la connexion à la BDD
            con.Open();

            Globale.lesMedicaments = new Dictionary<string, Medicament>();

            SqlCommand requete = new SqlCommand("prc_getMedicaments", con);
            requete.CommandType = System.Data.CommandType.StoredProcedure;
            requete.ExecuteNonQuery();

            SqlDataReader SqlDataRead = requete.ExecuteReader();

            while(SqlDataRead.Read())
            {
                string depotLegal = SqlDataRead["MED_DEPOTLEGAL"].ToString();
                string nomCommercial = SqlDataRead["MED_NOMCOMMERCIAL"].ToString();
                string composition = SqlDataRead["MED_COMPOSITION"].ToString();
                string effets = SqlDataRead["MED_EFFETS"].ToString();
                string contreIncic = SqlDataRead["MED_CONTREINDIC"].ToString();
                string medAmm = SqlDataRead["MED_AMM"].ToString();
                string famCode = SqlDataRead["FAM_CODE_MEDICAMENT"].ToString();

                Globale.lesMedicaments.Add(depotLegal, new Medicament(depotLegal, nomCommercial, composition, effets, contreIncic, medAmm));
            }

            SqlDataRead.Close();

            lvMedoc.Items.Clear();

            Dictionary<string, Medicament>.KeyCollection lesClesMedicaments = Globale.lesMedicaments.Keys;

            foreach (string lacle in lesClesMedicaments)
            {
                Medicament unMed = Globale.lesMedicaments[lacle];

                ListViewItem uneLiggne = new ListViewItem();
                uneLiggne.Text = unMed.getDepotLegal();
                uneLiggne.SubItems.Add(unMed.getNomCommercial());
                uneLiggne.SubItems.Add(unMed.getAmm());

                lvMedoc.Items.Add(uneLiggne);
            }
        }

       
        private void lvMedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
           lvEtapes.Items.Clear();

            if (lvMedoc.SelectedItems.Count > 0)
            {
                string valeurPremiereColonne = lvMedoc.SelectedItems[0].SubItems[0].Text;

                string connexion = "Data Source = DESKTOP-41R7HMR\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=true;User Id=DESKTOP-41R7HMR\\iliesjaaj;MultipleActiveResultSets=True";
                using (SqlConnection con = new SqlConnection(connexion))
                {
                    con.Open();

                    string query = "Select * from ETAPE INNER JOIN DERNIERE_VALIDATION ON ETAPE.ETP_NUM = DERNIERE_VALIDATION.ETP_NUM_DV INNER JOIN ETAPE_NORME ON DERNIERE_VALIDATION.ETP_NUM_DV = ETAPE_NORME.ETP_NUM_NORME WHERE MED_DEPOTLEGAL_DV = '" + valeurPremiereColonne + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DepotLegal", valeurPremiereColonne);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(reader.GetValue(5).ToString());
                        lvi.SubItems.Add(reader.GetValue(0).ToString());
                        lvi.SubItems.Add(reader.GetValue(2).ToString());
                        lvEtapes.Items.Add(lvi);
                    }
                }
            }

        }

    }
}