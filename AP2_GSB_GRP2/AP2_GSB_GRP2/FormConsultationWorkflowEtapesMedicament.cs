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
            Globale.lesMedicaments.Clear();

            // Cha�ne de connexion � la BDD
            string connexion = "Data Source = BTS2022-24\\SQLEXPRESS01; Initial Catalog = AP2-GP2; Integrated Security=true; User Id=DOMADJ\\medjenid";
            // Initialisation d'une connexion � la BDD � partir de la cha�ne de connexion
            SqlConnection con = new SqlConnection(connexion);
            // Ouverture de la connexion � la BDD
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
                string famCode = SqlDataRead["FAM_CODE_MEDCIAMENT"].ToString();

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
            string leClick = lvMedoc.Items[lvMedoc.FocusedItem.Index].Text;

            lvEtapes.Items.Clear();
            foreach (Workflow E in Globale.lesMedicaments[numLigClic].getLesEtapes())
            {
                ListViewItem ligne = new ListViewItem();
                ligne.Text = E.getEtape().getNum().ToString();
                ligne.SubItems.Add(numLigClic);
                ligne.SubItems.Add(E.getDateDecision().ToString());

                lv_med_workflow.Items.Add(ligne);
            }
        }
    }
}