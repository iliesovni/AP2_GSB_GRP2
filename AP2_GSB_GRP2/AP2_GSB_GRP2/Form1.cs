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

            // Affichez le Form2
            form2.Show();
        }
    }
}