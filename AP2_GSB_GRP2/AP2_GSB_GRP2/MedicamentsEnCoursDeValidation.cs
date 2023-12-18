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
            string query = "Select * from MEDICAMENT";
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
    }
}
