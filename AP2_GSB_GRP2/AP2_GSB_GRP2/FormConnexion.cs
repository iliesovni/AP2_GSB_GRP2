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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
         
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            string connexion = "Data Source = BTS2022-24\\SQLEXPRESS01; Initial Catalog = AP2-GP2; Integrated Security=true";
            SqlConnection con = new SqlConnection(connexion);
            con.Open();
            string requete = "SELECT * FROM UTILISATEUR";
            SqlCommand commande = new SqlCommand(requete, con);
            SqlDataReader reader = commande.ExecuteReader();

            bool utilisateurTrouve = false;

            while (reader.Read())
            {
                if (tbUsername.Text == reader.GetValue(1).ToString() && tbPassword.Text == reader.GetValue(7).ToString())
                {
                    utilisateurTrouve = true;
                    break;
                }
            }

            if (utilisateurTrouve)
            {
                MessageBox.Show("Connexion réussie !");
            }
            else
            {
                MessageBox.Show("Erreur lors de la saisie de vos identifiants");
            }

            con.Close(); // Fermer la connexion après utilisation


            // On affiche le menu et on ferme cette form
            Menu maFormMenu = new Menu();
            maFormMenu.Show();

            FormConnexion laFormCo = new FormConnexion();
            laFormCo.Close();

        }
    }
}
