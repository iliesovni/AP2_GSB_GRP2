using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_GSB_GRP2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnAjoutMedicament_Click(object sender, EventArgs e)
        {
            FormAjouterMedicament FormAjouterMedicament = new FormAjouterMedicament();
            FormAjouterMedicament.Show();
        }

        private void btnFormConsultationWorkflowMedicament_Click(object sender, EventArgs e)
        {
            FormConsultationWorkflowEtapesMedicament FormConsultationWorflowEtapesMedoc = new FormConsultationWorkflowEtapesMedicament();
            FormConsultationWorflowEtapesMedoc.Show();
        }

        private void btnNbMedicamentsAutoriserParFamille_Click(object sender, EventArgs e)
        {
            NbMedicamentsAutorisesParFamille FormNBMedocAutoriseParFamille = new NbMedicamentsAutorisesParFamille();
            FormNBMedocAutoriseParFamille.Show();
        }

        private void btnFormMedicamentsEnCoursDeValidation_Click(object sender, EventArgs e)
        {
            MedicamentsEnCoursDeValidation FormMedocEnCoursValidation = new MedicamentsEnCoursDeValidation();
            FormMedocEnCoursValidation.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSaisirDecision maForm = new FormSaisirDecision();
            maForm.Show();
                
             

        }
    }
}
