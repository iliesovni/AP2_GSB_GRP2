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
            string connexion = "Data Source = BTS2022-24\\SQLEXPRESS01; Initial Catalog = GSB_gesAMM; Integrated Security=true; User Id=DOMADJ\\medjenid";
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

        public void getLesEtapes()
        {
            Globale.lesEtapes = new List<Etape>();

            SqlCommand maRequete = new SqlCommand("prc_getEtapes");
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            maRequete.ExecuteNonQuery();

            SqlDataReader SqlDataRead = maRequete.ExecuteReader();

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
                    Globale.lesEtapes.Add(new Etape(num, libelle));
                }
                else
                {
                    Globale.lesEtapes.Add(new EtapeNormee(norme, dateNorme, num, libelle));
                }
            }

            SqlDataRead.Close();
        }

        private void lvMedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chaine de connexion à la BDD
            string connexion = "Data Source = BTS2022-24\\SQLEXPRESS01; Initial Catalog = GSB_gesAMM; Integrated Security=true; User Id=DOMADJ\\medjenid";
            // Initialisation d'une connexion � la BDD � partir de la cha�ne de connexion
            SqlConnection con = new SqlConnection(connexion);
            // Ouverture de la connexion à la BDD
            con.Open();

            string leClick = lvMedoc.Items[lvMedoc.FocusedItem.Index].Text;

            lvEtapes.Items.Clear();
            foreach (Etape uneEtape in Globale.lesMedicaments[leClick].getLesEtapes(con))
            {
                ListViewItem uneLigne = new ListViewItem();
                uneLigne.Text = uneEtape.getNum().ToString();
                uneLigne.SubItems.Add(leClick);

                lvEtapes.Items.Add(uneLigne);
            }
        }

    }
}