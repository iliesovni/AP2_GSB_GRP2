using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AP2_GSB_GRP2
{
    public partial class NbMedicamentsAutorisesParFamille : Form
    {
        public NbMedicamentsAutorisesParFamille()
        {
            InitializeComponent();
        }

        private void LV_Famille_Autorises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Famille_Autorises.SelectedItems.Count > 0)
            {
                LV_Medicaments_Autorises.Items.Clear();
                string valeurPremiereColonne = LV_Famille_Autorises.SelectedItems[0].SubItems[0].Text;
                string connstring = "Data Source = DESKTOP-41R7HMR\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=true;User Id=DESKTOP-41R7HMR\\iliesjaaj;MultipleActiveResultSets=True";
                SqlConnection con = new SqlConnection(connstring);
                con.Open();
                string query = "Select * from MEDICAMENT Where FAM_CODE_MEDICAMENT = '" + valeurPremiereColonne + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SqlCommand verifCmd = new SqlCommand("VerifierMedicamentDansEtapeNormee", con);
                    verifCmd.CommandType = CommandType.StoredProcedure;
                    verifCmd.Parameters.AddWithValue("@MED_DEPOTLEGAL", reader.GetValue(0).ToString());

                    SqlParameter resultatParam = new SqlParameter("@Resultat", SqlDbType.Int);
                    resultatParam.Direction = ParameterDirection.Output;
                    verifCmd.Parameters.Add(resultatParam);

                    verifCmd.ExecuteNonQuery();

                    int resultat = Convert.ToInt32(verifCmd.Parameters["@Resultat"].Value);

                    if (resultat == 1)
                    { 
                    ListViewItem lvi = new ListViewItem(reader.GetValue(0).ToString());
                    lvi.SubItems.Add(reader.GetValue(1).ToString());
                    lvi.SubItems.Add(reader.GetValue(6).ToString());
                    LV_Medicaments_Autorises.Items.Add(lvi);
                    }
                }
                con.Close();
            }
        }

        private void NbMedicamentsAutorisesParFamille_Load(object sender, EventArgs e)
        {
            LV_Famille_Autorises.Items.Clear();
            string connstring = "Data Source = DESKTOP-41R7HMR\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=true;User Id=DESKTOP-41R7HMR\\iliesjaaj";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();

            SqlCommand updateCmd = new SqlCommand("MiseAJourNombreMedicaments", con);
            updateCmd.CommandType = CommandType.StoredProcedure;
            updateCmd.ExecuteNonQuery();

            string query = "Select FAM_CODE, FAM_LIBELLE, FAM_NB_MED_AMM from FAMILLE;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetValue(0).ToString());
                lvi.SubItems.Add(reader.GetValue(1).ToString());
                lvi.SubItems.Add(reader.GetValue(2).ToString());
                LV_Famille_Autorises.Items.Add(lvi);
            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
