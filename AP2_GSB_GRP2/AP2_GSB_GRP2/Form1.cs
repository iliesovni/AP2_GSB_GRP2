using System.Data.SqlClient;

namespace AP2_GSB_GRP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NbMedicamentsAutorisesParFamille form2 = new NbMedicamentsAutorisesParFamille();
            form2.Show();

            string connstring = "Data Source = BTS2022-19\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=true;User Id=DOMADJ\\izikkii";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string query = "Select * from FAMILLE;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Famille laFamille = new Famille(reader.GetValue(0).ToString(), reader.GetValue(1).ToString());
                Globale.lesFamilles.Add(reader.GetValue(1).ToString(), laFamille);
            }
            con.Close();
        }
    }
}