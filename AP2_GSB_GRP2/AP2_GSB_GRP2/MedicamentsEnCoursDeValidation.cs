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

namespace AP2_GSB_GRP2
{
    public partial class MedicamentsEnCoursDeValidation : Form
    {
        public MedicamentsEnCoursDeValidation()
        {
            InitializeComponent();
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MedicamentsEnCoursDeValidation_Load(object sender, EventArgs e)
        {
            LV_Medicaments_Validation.Items.Clear();
            string connstring = "Data Source = DESKTOP-41R7HMR\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=true;User Id=DESKTOP-41R7HMR\\iliesjaaj;MultipleActiveResultSets=True";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string query = "Select * from MEDICAMENT WHERE MED_DEPOTLEGAL IN (SELECT MED_DEPOTLEGAL_DV FROM DERNIERE_VALIDATION)\r\n";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetValue(0).ToString());
                lvi.SubItems.Add(reader.GetValue(1).ToString());
                lvi.SubItems.Add(reader.GetValue(6).ToString());
                LV_Medicaments_Validation.Items.Add(lvi);
            }
        }

        private void LV_Medicaments_Validation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LV_Medicaments_Validation_Click(object sender, EventArgs e)
        {
            LV_Etape_Validation.Items.Clear();
            string valeurPremiereColonne = LV_Medicaments_Validation.SelectedItems[0].SubItems[0].Text;
            string connstring = "Data Source = DESKTOP-41R7HMR\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=true;User Id=DESKTOP-41R7HMR\\iliesjaaj;MultipleActiveResultSets=True";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string query = "Select * from ETAPE INNER JOIN DERNIERE_VALIDATION ON ETAPE.ETP_NUM = DERNIERE_VALIDATION.ETP_NUM_DV INNER JOIN ETAPE_NORME ON DERNIERE_VALIDATION.ETP_NUM_DV = ETAPE_NORME.ETP_NUM_NORME WHERE MED_DEPOTLEGAL_DV = '" + valeurPremiereColonne + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetValue(5).ToString());
                lvi.SubItems.Add(reader.GetValue(0).ToString());
                lvi.SubItems.Add(reader.GetValue(2).ToString());
                LV_Etape_Validation.Items.Add(lvi);
            }
        }

        private void MedicamentsEnCoursDeValidation_Load_1(object sender, EventArgs e)
        {

        }

        private void MedicamentsEnCoursDeValidation_Load_2(object sender, EventArgs e)
        {

        }

        private void MedicamentsEnCoursDeValidation_Load_3(object sender, EventArgs e)
        {

        }

        private void LV_Medicaments_Validation_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
