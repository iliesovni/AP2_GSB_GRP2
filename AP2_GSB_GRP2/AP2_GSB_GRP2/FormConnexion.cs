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
            // Chaîne de connexion à la BDD
            string connexion = "Data Source = BTS2022-24\\SQLEXPRESS01; Initial Catalog = AP2-GP2; Integrated Security=true";

            // Initialisation d'une connexion à la BDD à partir de la chaîne de connexion
            SqlConnection con = new SqlConnection(connexion);

            // Ouverture de la connexion à la BDD
            con.Open();

            // Création d'un requête
            string requete = "SELECT * FROM UTILISATEUR";

            // Création d'un objet "Command" prenant la requete et la connexion en paramètre
            SqlCommand commande = new SqlCommand(requete, con);

            // Exécution de la requête
            SqlDataReader reader = commande.ExecuteReader();

            bool utilisateurTrouve = false;

            // Parcours des données récupérées
            while (reader.Read())
            {
                // On vérifie si le nom et le mdp correspondent à ceux en BDD
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

            // Fermeture de la connexion à la base de données
            con.Close();


            // On affiche le menu et on ferme cette form
            Menu maFormMenu = new Menu();
            maFormMenu.Show();

            FormConnexion laFormCo = new FormConnexion();
            laFormCo.Close();

        }
    }
}
