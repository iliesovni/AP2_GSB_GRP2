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
                string connstring = "Data Source = BTS2022-19\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=true;User Id=DOMADJ\\izikkii";
                SqlConnection con = new SqlConnection(connstring);
                con.Open();
                string query = "Select * from MEDICAMENT Where FAM_CODE_MEDICAMENT = '" + valeurPremiereColonne + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetValue(0).ToString());
                    lvi.SubItems.Add(reader.GetValue(1).ToString());
                    lvi.SubItems.Add(reader.GetValue(6).ToString());
                    LV_Medicaments_Autorises.Items.Add(lvi);
                }
            }
        }

        private void NbMedicamentsAutorisesParFamille_Load(object sender, EventArgs e)
        {
            LV_Famille_Autorises.Items.Clear();
            string connstring = "Data Source = BTS2022-19\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=true;User Id=DOMADJ\\izikkii";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string query = "Select * from FAMILLE;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetValue(0).ToString());
                lvi.SubItems.Add(reader.GetValue(1).ToString());
                lvi.SubItems.Add(reader.GetValue(2).ToString());
                LV_Famille_Autorises.Items.Add(lvi);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
