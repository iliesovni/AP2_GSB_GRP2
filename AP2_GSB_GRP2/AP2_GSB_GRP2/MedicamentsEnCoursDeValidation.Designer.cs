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
            this.PB_LogoValidation = new System.Windows.Forms.PictureBox();
            this.LV_Medicaments_Validation = new System.Windows.Forms.ListView();
            this.CH_DepotLegal_LV_MedicamentsValidation = new System.Windows.Forms.ColumnHeader();
            this.CH_NomCommercial_LV_MedicamentsValidation = new System.Windows.Forms.ColumnHeader();
            this.CH_CodeFamille_LV_MedicamentsValidation = new System.Windows.Forms.ColumnHeader();
            this.LV_Etape_Validation = new System.Windows.Forms.ListView();
            this.CH_DateEtape_LV_EtapeValidation = new System.Windows.Forms.ColumnHeader();
            this.CH_NumEtape_LV_EtapeValidation = new System.Windows.Forms.ColumnHeader();
            this.CH_IdDecision_LV_EtapeValidation = new System.Windows.Forms.ColumnHeader();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_LogoValidation
            // 
            this.PB_LogoValidation.Image = global::AP2_GSB_GRP2.Properties.Resources.Logo_GSB;
            this.PB_LogoValidation.Location = new System.Drawing.Point(0, 2);
            this.PB_LogoValidation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_LogoValidation.Name = "PB_LogoValidation";
            this.PB_LogoValidation.Size = new System.Drawing.Size(180, 98);
            this.PB_LogoValidation.TabIndex = 1;
            this.PB_LogoValidation.TabStop = false;
            // 
            // LV_Medicaments_Validation
            // 
            this.LV_Medicaments_Validation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_DepotLegal_LV_MedicamentsValidation,
            this.CH_NomCommercial_LV_MedicamentsValidation,
            this.CH_CodeFamille_LV_MedicamentsValidation});
            this.LV_Medicaments_Validation.Location = new System.Drawing.Point(40, 104);
            this.LV_Medicaments_Validation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LV_Medicaments_Validation.Name = "LV_Medicaments_Validation";
            this.LV_Medicaments_Validation.Size = new System.Drawing.Size(363, 261);
            this.LV_Medicaments_Validation.TabIndex = 5;
            this.LV_Medicaments_Validation.UseCompatibleStateImageBehavior = false;
            this.LV_Medicaments_Validation.View = System.Windows.Forms.View.Details;
            this.LV_Medicaments_Validation.SelectedIndexChanged += new System.EventHandler(this.LV_Medicaments_Validation_SelectedIndexChanged_1);
            // 
            // CH_DepotLegal_LV_MedicamentsValidation
            // 
            this.CH_DepotLegal_LV_MedicamentsValidation.Text = "DepotLegal";
            this.CH_DepotLegal_LV_MedicamentsValidation.Width = 100;
            // 
            // CH_NomCommercial_LV_MedicamentsValidation
            // 
            this.CH_NomCommercial_LV_MedicamentsValidation.Text = "NomCommercial";
            this.CH_NomCommercial_LV_MedicamentsValidation.Width = 130;
            // 
            // CH_CodeFamille_LV_MedicamentsValidation
            // 
            this.CH_CodeFamille_LV_MedicamentsValidation.Text = "CodeFamille";
            this.CH_CodeFamille_LV_MedicamentsValidation.Width = 100;
            // 
            // LV_Etape_Validation
            // 
            this.LV_Etape_Validation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_DateEtape_LV_EtapeValidation,
            this.CH_NumEtape_LV_EtapeValidation,
            this.CH_IdDecision_LV_EtapeValidation});
            this.LV_Etape_Validation.Location = new System.Drawing.Point(450, 104);
            this.LV_Etape_Validation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LV_Etape_Validation.Name = "LV_Etape_Validation";
            this.LV_Etape_Validation.Size = new System.Drawing.Size(363, 261);
            this.LV_Etape_Validation.TabIndex = 6;
            this.LV_Etape_Validation.UseCompatibleStateImageBehavior = false;
            this.LV_Etape_Validation.View = System.Windows.Forms.View.Details;
            // 
            // CH_DateEtape_LV_EtapeValidation
            // 
            this.CH_DateEtape_LV_EtapeValidation.Text = "Date";
            this.CH_DateEtape_LV_EtapeValidation.Width = 100;
            // 
            // CH_NumEtape_LV_EtapeValidation
            // 
            this.CH_NumEtape_LV_EtapeValidation.Text = "NumEtape";
            this.CH_NumEtape_LV_EtapeValidation.Width = 100;
            // 
            // CH_IdDecision_LV_EtapeValidation
            // 
            this.CH_IdDecision_LV_EtapeValidation.Text = "IdDecision";
            this.CH_IdDecision_LV_EtapeValidation.Width = 100;
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(730, 368);
            this.BTN_Quitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(82, 22);
            this.BTN_Quitter.TabIndex = 8;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(240, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Médicaments en cours de validation";
            // 
            // MedicamentsEnCoursDeValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(852, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.LV_Etape_Validation);
            this.Controls.Add(this.LV_Medicaments_Validation);
            this.Controls.Add(this.PB_LogoValidation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MedicamentsEnCoursDeValidation";
            this.Text = "MedicamentsEnCoursDeValidation";
            this.Load += new System.EventHandler(this.MedicamentsEnCoursDeValidation_Load_3);
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoValidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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