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
            // Cha�ne de connexion � la BDD
            string connexion = "Data Source = BTS2022-24\\SQLEXPRESS01; Initial Catalog = AP2-GP2; Integrated Security=true";

            // Initialisation d'une connexion � la BDD � partir de la cha�ne de connexion
            SqlConnection con = new SqlConnection(connexion);

            // Ouverture de la connexion � la BDD
            con.Open();


        }
    }
}