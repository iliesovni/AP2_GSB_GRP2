using System;
using System.Collections;
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
            // Pour que le Mdp soit écrit avec des "*"
            tbPassword.PasswordChar = '*';

        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            // A REFAIRE AVEC UNE PROCEDURE
            // Chaîne de connexion à la BDD
            Connexion uneConnexion = new Connexion("BTS2022-24\\SQLEXPRESS01", "GSB_gesAMM");

            // Création d'un requête
            string requete = "SELECT NOM, MOT_DE_PASSE FROM UTILISATEUR";

            // Création d'un objet "Command" prenant la requete et la connexion en paramètre
            SqlCommand commande = new SqlCommand(requete, uneConnexion.getCon());

            // Exécution de la requête
            SqlDataReader reader = commande.ExecuteReader();

            bool utilisateurTrouve = false;

            // Parcours des données récupérées
            while (reader.Read())
            {
                // On récupère le mot de passe haché stocké en base de données (supposons que c'est en hexadécimal)
                string motDePasseBDD = reader.GetValue(1).ToString();

                // On hache le mot de passe saisi pour le comparer au mot de passe en base de données
                var bytes = new UTF8Encoding().GetBytes(tbPassword.Text);
                var sha256 = System.Security.Cryptography.SHA256.Create();
                var hash = sha256.ComputeHash(bytes);
                string mdpSaisi = BitConverter.ToString(hash).Replace("-", "").ToLower(); // Conversion en représentation hexadécimale

                // On vérifie si le nom d'utilisateur correspond ET si les mots de passe hachés correspondent
                if (tbUsername.Text == reader.GetValue(0).ToString() && mdpSaisi == motDePasseBDD)
                {
                    utilisateurTrouve = true;
                    break;
                }
            }



            if (utilisateurTrouve)
            {
                MessageBox.Show("Connexion effectuée", "Message : Authentification réussie !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                // On affiche le menu et on ferme cette form
                Menu maFormMenu = new Menu();
                // Display the new form.  
                maFormMenu.Show();

                FormConnexion laFormCo = new FormConnexion();
                laFormCo.Close();

            }
            else
            {
                MessageBox.Show("Les données saisies sont incorrectes, veuillez les vérifier", "Erreur : Données d'authentifications incorrectes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Fermeture de la connexion à la base de données
            //con.Close();


            

        }
    }
}
