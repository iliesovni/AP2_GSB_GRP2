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
            lvMedoc.Items.Clear();
            // Cha�ne de connexion � la BDD
            string connexion = "Data Source = BTS2022-24\\SQLEXPRESS01; Initial Catalog = AP2-GP2; Integrated Security=true";
            // Initialisation d'une connexion � la BDD � partir de la cha�ne de connexion
            SqlConnection con = new SqlConnection(connexion);
            // Ouverture de la connexion � la BDD
            con.Open();

           // SqlCommand 
        }

        private void lvMedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvMedoc.Items.Count > 0)
            {
                lvMedoc.Items.Clear();
                string valeurPremiereColonne = lvMedoc.SelectedItems[0].SubItems[0].Text;

                // Cha�ne de connexion � la BDD
                string connexion = "Data Source = BTS2022-24\\SQLEXPRESS01; Initial Catalog = AP2-GP2; Integrated Security=true";
                // Initialisation d'une connexion � la BDD � partir de la cha�ne de connexion
                SqlConnection con = new SqlConnection(connexion);
                // Ouverture de la connexion � la BDD
                con.Open();

                string requete = "Select * from MEDICAMENT Where FAM_CODE_MEDICAMENT = '" + valeurPremiereColonne + "';";

                SqlCommand cmd = new SqlCommand(requete, con);
                SqlDataReader reader = cmd.ExecuteReader(); 

                while(reader.Read())
                {
                    ListViewItem uneligne = new ListViewItem(reader.GetValue(0).ToString());
                    uneligne.SubItems.Add(reader.GetValue(1).ToString());
                    uneligne.SubItems.Add(reader.GetValue(6).ToString());
                    lvMedoc.Items.Add(uneligne);
                }
            }
        }
    }
}