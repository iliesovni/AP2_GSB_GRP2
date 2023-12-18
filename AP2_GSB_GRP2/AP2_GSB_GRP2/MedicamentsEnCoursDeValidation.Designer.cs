namespace AP2_GSB_GRP2
{
    partial class MedicamentsEnCoursDeValidation
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
            PB_LogoValidation = new PictureBox();
            LV_Medicaments_Validation = new ListView();
            CH_DepotLegal_LV_MedicamentsValidation = new ColumnHeader();
            CH_NomCommercial_LV_MedicamentsValidation = new ColumnHeader();
            CH_CodeFamille_LV_MedicamentsValidation = new ColumnHeader();
            LV_Etape_Validation = new ListView();
            CH_DateEtape_LV_EtapeValidation = new ColumnHeader();
            CH_NumEtape_LV_EtapeValidation = new ColumnHeader();
            CH_IdDecision_LV_EtapeValidation = new ColumnHeader();
            BTN_Quitter = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PB_LogoValidation).BeginInit();
            SuspendLayout();
            // 
            // PB_LogoValidation
            // 
            PB_LogoValidation.Image = Properties.Resources.Logo_GSB;
            PB_LogoValidation.Location = new Point(0, 2);
            PB_LogoValidation.Margin = new Padding(3, 2, 3, 2);
            PB_LogoValidation.Name = "PB_LogoValidation";
            PB_LogoValidation.Size = new Size(180, 98);
            PB_LogoValidation.TabIndex = 1;
            PB_LogoValidation.TabStop = false;
            // 
            // LV_Medicaments_Validation
            // 
            LV_Medicaments_Validation.Columns.AddRange(new ColumnHeader[] { CH_DepotLegal_LV_MedicamentsValidation, CH_NomCommercial_LV_MedicamentsValidation, CH_CodeFamille_LV_MedicamentsValidation });
            LV_Medicaments_Validation.Location = new Point(40, 104);
            LV_Medicaments_Validation.Margin = new Padding(3, 2, 3, 2);
            LV_Medicaments_Validation.Name = "LV_Medicaments_Validation";
            LV_Medicaments_Validation.Size = new Size(363, 261);
            LV_Medicaments_Validation.TabIndex = 5;
            LV_Medicaments_Validation.UseCompatibleStateImageBehavior = false;
            LV_Medicaments_Validation.View = View.Details;
            LV_Medicaments_Validation.SelectedIndexChanged += LV_Medicaments_Validation_SelectedIndexChanged;
            LV_Medicaments_Validation.Click += LV_Medicaments_Validation_Click;
            // 
            // CH_DepotLegal_LV_MedicamentsValidation
            // 
            CH_DepotLegal_LV_MedicamentsValidation.Text = "DepotLegal";
            CH_DepotLegal_LV_MedicamentsValidation.Width = 100;
            // 
            // CH_NomCommercial_LV_MedicamentsValidation
            // 
            CH_NomCommercial_LV_MedicamentsValidation.Text = "NomCommercial";
            CH_NomCommercial_LV_MedicamentsValidation.Width = 130;
            // 
            // CH_CodeFamille_LV_MedicamentsValidation
            // 
            CH_CodeFamille_LV_MedicamentsValidation.Text = "CodeFamille";
            CH_CodeFamille_LV_MedicamentsValidation.Width = 100;
            // 
            // LV_Etape_Validation
            // 
            LV_Etape_Validation.Columns.AddRange(new ColumnHeader[] { CH_DateEtape_LV_EtapeValidation, CH_NumEtape_LV_EtapeValidation, CH_IdDecision_LV_EtapeValidation });
            LV_Etape_Validation.Location = new Point(450, 104);
            LV_Etape_Validation.Margin = new Padding(3, 2, 3, 2);
            LV_Etape_Validation.Name = "LV_Etape_Validation";
            LV_Etape_Validation.Size = new Size(363, 261);
            LV_Etape_Validation.TabIndex = 6;
            LV_Etape_Validation.UseCompatibleStateImageBehavior = false;
            LV_Etape_Validation.View = View.Details;
            // 
            // CH_DateEtape_LV_EtapeValidation
            // 
            CH_DateEtape_LV_EtapeValidation.Text = "Date";
            CH_DateEtape_LV_EtapeValidation.Width = 100;
            // 
            // CH_NumEtape_LV_EtapeValidation
            // 
            CH_NumEtape_LV_EtapeValidation.Text = "NumEtape";
            CH_NumEtape_LV_EtapeValidation.Width = 100;
            // 
            // CH_IdDecision_LV_EtapeValidation
            // 
            CH_IdDecision_LV_EtapeValidation.Text = "IdDecision";
            CH_IdDecision_LV_EtapeValidation.Width = 100;
            // 
            // BTN_Quitter
            // 
            BTN_Quitter.Location = new Point(730, 368);
            BTN_Quitter.Margin = new Padding(3, 2, 3, 2);
            BTN_Quitter.Name = "BTN_Quitter";
            BTN_Quitter.Size = new Size(82, 22);
            BTN_Quitter.TabIndex = 8;
            BTN_Quitter.Text = "Quitter";
            BTN_Quitter.UseVisualStyleBackColor = true;
            BTN_Quitter.Click += BTN_Quitter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(240, 38);
            label2.Name = "label2";
            label2.Size = new Size(419, 34);
            label2.TabIndex = 9;
            label2.Text = "Médicaments en cours de validation";
            // 
            // MedicamentsEnCoursDeValidation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(852, 398);
            Controls.Add(label2);
            Controls.Add(BTN_Quitter);
            Controls.Add(LV_Etape_Validation);
            Controls.Add(LV_Medicaments_Validation);
            Controls.Add(PB_LogoValidation);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MedicamentsEnCoursDeValidation";
            Text = "MedicamentsEnCoursDeValidation";
            Load += MedicamentsEnCoursDeValidation_Load;
            ((System.ComponentModel.ISupportInitialize)PB_LogoValidation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PB_LogoValidation;
        private ListView LV_Medicaments_Validation;
        private ColumnHeader CH_DepotLegal_LV_MedicamentsValidation;
        private ColumnHeader CH_NomCommercial_LV_MedicamentsValidation;
        private ColumnHeader CH_CodeFamille_LV_MedicamentsValidation;
        private ListView LV_Etape_Validation;
        private ColumnHeader CH_DateEtape_LV_EtapeValidation;
        private ColumnHeader CH_NumEtape_LV_EtapeValidation;
        private ColumnHeader CH_IdDecision_LV_EtapeValidation;
        private Button BTN_Quitter;
        private Label label2;
    }
}