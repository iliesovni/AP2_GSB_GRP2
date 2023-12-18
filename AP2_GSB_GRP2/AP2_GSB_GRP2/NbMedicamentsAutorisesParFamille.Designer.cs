namespace AP2_GSB_GRP2
{
    partial class NbMedicamentsAutorisesParFamille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PB_LogoAutorises = new PictureBox();
            LV_Famille_Autorises = new ListView();
            CH_CodeFamille = new ColumnHeader();
            CH_NomFamille = new ColumnHeader();
            CH_NbMedoc = new ColumnHeader();
            LV_Medicaments_Autorises = new ListView();
            CH_DepotLegal = new ColumnHeader();
            CH_NomCommerce = new ColumnHeader();
            CH_CodeFamilleMedoc = new ColumnHeader();
            BTN_Quitter = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PB_LogoAutorises).BeginInit();
            SuspendLayout();
            // 
            // PB_LogoAutorises
            // 
            PB_LogoAutorises.Image = Properties.Resources.Logo_GSB;
            PB_LogoAutorises.Location = new Point(-1, 0);
            PB_LogoAutorises.Margin = new Padding(3, 2, 3, 2);
            PB_LogoAutorises.Name = "PB_LogoAutorises";
            PB_LogoAutorises.Size = new Size(183, 100);
            PB_LogoAutorises.TabIndex = 0;
            PB_LogoAutorises.TabStop = false;
            // 
            // LV_Famille_Autorises
            // 
            LV_Famille_Autorises.Columns.AddRange(new ColumnHeader[] { CH_CodeFamille, CH_NomFamille, CH_NbMedoc });
            LV_Famille_Autorises.Location = new Point(40, 104);
            LV_Famille_Autorises.Margin = new Padding(3, 2, 3, 2);
            LV_Famille_Autorises.MultiSelect = false;
            LV_Famille_Autorises.Name = "LV_Famille_Autorises";
            LV_Famille_Autorises.Size = new Size(363, 261);
            LV_Famille_Autorises.TabIndex = 3;
            LV_Famille_Autorises.UseCompatibleStateImageBehavior = false;
            LV_Famille_Autorises.View = View.Details;
            LV_Famille_Autorises.SelectedIndexChanged += LV_Famille_Autorises_SelectedIndexChanged_1;
            LV_Famille_Autorises.Click += LV_Famille_Autorises_Click;
            // 
            // CH_CodeFamille
            // 
            CH_CodeFamille.Text = "Code Famille";
            CH_CodeFamille.Width = 120;
            // 
            // CH_NomFamille
            // 
            CH_NomFamille.Text = "Nom Famille";
            CH_NomFamille.Width = 120;
            // 
            // CH_NbMedoc
            // 
            CH_NbMedoc.Text = "Nb Médicaments";
            CH_NbMedoc.Width = 160;
            // 
            // LV_Medicaments_Autorises
            // 
            LV_Medicaments_Autorises.Columns.AddRange(new ColumnHeader[] { CH_DepotLegal, CH_NomCommerce, CH_CodeFamilleMedoc });
            LV_Medicaments_Autorises.Location = new Point(450, 104);
            LV_Medicaments_Autorises.Margin = new Padding(3, 2, 3, 2);
            LV_Medicaments_Autorises.Name = "LV_Medicaments_Autorises";
            LV_Medicaments_Autorises.Size = new Size(363, 261);
            LV_Medicaments_Autorises.TabIndex = 4;
            LV_Medicaments_Autorises.UseCompatibleStateImageBehavior = false;
            LV_Medicaments_Autorises.View = View.Details;
            // 
            // CH_DepotLegal
            // 
            CH_DepotLegal.Text = "Dépot Légal";
            CH_DepotLegal.Width = 120;
            // 
            // CH_NomCommerce
            // 
            CH_NomCommerce.Text = "Nom Commercial";
            CH_NomCommerce.Width = 160;
            // 
            // CH_CodeFamilleMedoc
            // 
            CH_CodeFamilleMedoc.Text = "Code Famille";
            CH_CodeFamilleMedoc.Width = 120;
            // 
            // BTN_Quitter
            // 
            BTN_Quitter.Location = new Point(730, 370);
            BTN_Quitter.Margin = new Padding(3, 2, 3, 2);
            BTN_Quitter.Name = "BTN_Quitter";
            BTN_Quitter.Size = new Size(82, 22);
            BTN_Quitter.TabIndex = 6;
            BTN_Quitter.Text = "Quitter";
            BTN_Quitter.UseVisualStyleBackColor = true;
            BTN_Quitter.Click += BTN_Quitter_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(200, 34);
            label2.Name = "label2";
            label2.Size = new Size(550, 29);
            label2.TabIndex = 10;
            label2.Text = "Nombre de médicaments autorisés par famille";
            // 
            // NbMedicamentsAutorisesParFamille
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(852, 398);
            Controls.Add(label2);
            Controls.Add(BTN_Quitter);
            Controls.Add(LV_Medicaments_Autorises);
            Controls.Add(LV_Famille_Autorises);
            Controls.Add(PB_LogoAutorises);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NbMedicamentsAutorisesParFamille";
            Text = "NbMedicamentsAutorisesParFamille";
            Load += NbMedicamentsAutorisesParFamille_Load_1;
            ((System.ComponentModel.ISupportInitialize)PB_LogoAutorises).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion


        private PictureBox PB_LogoAutorises;
        private ListView LV_Famille_Autorises;
        private ListView LV_Medicaments_Autorises;
        private Button BTN_Quitter;
        private ColumnHeader CH_CodeFamille_LV_FamilleAutorises;
        private ColumnHeader CH_NomFamille_LV_FamilleAutorises;
        private ColumnHeader CH_NbMedicaments_LV_FamilleAutorises;
        private ColumnHeader CH_DepotLegal_LV_MedicamentsAutorises;
        private ColumnHeader CH_NomCommercial_LV_MedicamentsAutorises;
        private ColumnHeader CH_CodeFamille_LV_MedicamentsAutorises;
        private Label label2;
        private ColumnHeader CH_CodeFamille;
        private ColumnHeader CH_NomFamille;
        private ColumnHeader CH_NbMedoc;
        private ColumnHeader CH_DepotLegal;
        private ColumnHeader CH_NomCommerce;
        private ColumnHeader CH_CodeFamilleMedoc;
    }
}