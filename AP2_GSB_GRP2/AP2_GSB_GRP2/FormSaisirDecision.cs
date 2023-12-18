using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_GSB_GRP2
{
    public partial class FormSaisirDecision : Form
    {
        string leClickM;
        string leClickE;

        public FormSaisirDecision()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string leClick = lvMedoc.Items[lvMedoc.FocusedItem.Index].Text;

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void FormSaisirDecision_Load(object sender, EventArgs e)
        {
            Connexion cnx = new Connexion("DESKTOP-26S0M0E\\SQLEXPRESS", "GSB_gesAMM");
            SqlCommand cmd = new SqlCommand("prc_getMedicaments", cnx.getCo());
            SqlCommand cmdE = new SqlCommand("prc_getEtapesNonValide", cnx.getCo());

            cmd.CommandType = CommandType.StoredProcedure;
            cmdE.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            cmdE.ExecuteNonQuery();

            SqlDataReader SqlDataRead = cmd.ExecuteReader();
            SqlDataReader SqlDataReadE = cmdE.ExecuteReader();


            while (SqlDataRead.Read()) 
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

            while (SqlDataReadE.Read())
            {
                string etapelibelle = SqlDataReadE["ETP_LIBELLE"].ToString();
                int id = SqlDataReadE["ETP_NUM"].GetHashCode();

                Globale.lesEtapes.Add(new Etape(id, etapelibelle));
            }


            SqlDataRead.Close();
            SqlDataReadE.Close();

            lvMedoc.Items.Clear();
            lvE.Items.Clear();

            Dictionary<string, Medicament>.KeyCollection lesClesMedicaments = Globale.lesMedicaments.Keys;

            foreach (string lacle in lesClesMedicaments)
            {
                Medicament unMed = Globale.lesMedicaments[lacle];

                ListViewItem uneLiggne = new ListViewItem();
                uneLiggne.Text = unMed.getDepotLegal();
                uneLiggne.SubItems.Add(unMed.getNomCommercial());
                

                lvMedoc.Items.Add(uneLiggne);
            }

            foreach (Etape etp in Globale.lesEtapes)
            {
                ListViewItem uneLiggne = new ListViewItem();
                uneLiggne.Text = etp.getNum().ToString() ;
                uneLiggne.SubItems.Add(etp.getLibelle());


                lvE.Items.Add(uneLiggne);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           leClickM = lvMedoc.Items[lvMedoc.FocusedItem.Index].Text;
            MessageBox.Show(leClickM);

        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
}
