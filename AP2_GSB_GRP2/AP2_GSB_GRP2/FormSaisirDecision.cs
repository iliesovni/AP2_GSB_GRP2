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
            // Assurez-vous que quelque chose est sélectionné dans la ListView
            if (lvMedoc.SelectedItems.Count > 0)
            {
                string leClickM = lvMedoc.SelectedItems[0].Text;
                string leClickE = lvE.SelectedItems[0].Text; // Assurez-vous que vous utilisez la ListView correcte pour l'étape

                MessageBox.Show($"Medicament: {leClickM}, Etape: {leClickE}");

                Connexion cnx = new Connexion("DESKTOP-26S0M0E\\SQLEXPRESS", "GSB_gesAMM");
                SqlCommand cmdD = new SqlCommand("prc_ajout_decision", cnx.getCo());

                try
                {
                    // Ajout des paramètres avec leurs valeurs
                    cmdD.Parameters.Add(new SqlParameter("@idMedicament", SqlDbType.VarChar, 250)).Value = leClickM;
                    cmdD.Parameters.Add(new SqlParameter("@idEtape", SqlDbType.Int)).Value = int.Parse(leClickE);
                    cmdD.Parameters.Add(new SqlParameter("@decisionLibelle", SqlDbType.VarChar, 250)).Value = tbDecision.Text;

                    // Exécution de la procédure stockée
                    cmdD.CommandType = CommandType.StoredProcedure;
                    cmdD.ExecuteNonQuery();

                    // Affichage du message après l'insertion réussie
                    MessageBox.Show("La décision a été ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception x)
                {
                    // Affichage du message d'erreur en cas d'échec
                    MessageBox.Show(x.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un médicament et une étape.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
}
