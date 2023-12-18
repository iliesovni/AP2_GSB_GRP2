﻿namespace AP2_GSB_GRP2
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
            this.PB_LogoAutorises = new System.Windows.Forms.PictureBox();
            this.LV_Famille_Autorises = new System.Windows.Forms.ListView();
            this.CH_CodeFamille = new System.Windows.Forms.ColumnHeader();
            this.CH_NomFamille = new System.Windows.Forms.ColumnHeader();
            this.CH_NbMedoc = new System.Windows.Forms.ColumnHeader();
            this.LV_Medicaments_Autorises = new System.Windows.Forms.ListView();
            this.CH_DepotLegal = new System.Windows.Forms.ColumnHeader();
            this.CH_NomCommerce = new System.Windows.Forms.ColumnHeader();
            this.CH_CodeFamilleMedoc = new System.Windows.Forms.ColumnHeader();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoAutorises)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_LogoAutorises
            // 
            this.PB_LogoAutorises.Image = global::AP2_GSB_GRP2.Properties.Resources.Logo_GSB;
            this.PB_LogoAutorises.Location = new System.Drawing.Point(-1, 0);
            this.PB_LogoAutorises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_LogoAutorises.Name = "PB_LogoAutorises";
            this.PB_LogoAutorises.Size = new System.Drawing.Size(183, 100);
            this.PB_LogoAutorises.TabIndex = 0;
            this.PB_LogoAutorises.TabStop = false;
            // 
            // LV_Famille_Autorises
            // 
            this.LV_Famille_Autorises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_CodeFamille,
            this.CH_NomFamille,
            this.CH_NbMedoc});
            this.LV_Famille_Autorises.Location = new System.Drawing.Point(40, 104);
            this.LV_Famille_Autorises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LV_Famille_Autorises.MultiSelect = false;
            this.LV_Famille_Autorises.Name = "LV_Famille_Autorises";
            this.LV_Famille_Autorises.Size = new System.Drawing.Size(363, 261);
            this.LV_Famille_Autorises.TabIndex = 3;
            this.LV_Famille_Autorises.UseCompatibleStateImageBehavior = false;
            this.LV_Famille_Autorises.View = System.Windows.Forms.View.Details;
            this.LV_Famille_Autorises.SelectedIndexChanged += new System.EventHandler(this.LV_Famille_Autorises_SelectedIndexChanged_1);
            // 
            // CH_CodeFamille
            // 
            this.CH_CodeFamille.Text = "Code Famille";
            this.CH_CodeFamille.Width = 120;
            // 
            // CH_NomFamille
            // 
            this.CH_NomFamille.Text = "Nom Famille";
            this.CH_NomFamille.Width = 120;
            // 
            // CH_NbMedoc
            // 
            this.CH_NbMedoc.Text = "Nb Médicaments";
            this.CH_NbMedoc.Width = 160;
            // 
            // LV_Medicaments_Autorises
            // 
            this.LV_Medicaments_Autorises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_DepotLegal,
            this.CH_NomCommerce,
            this.CH_CodeFamilleMedoc});
            this.LV_Medicaments_Autorises.Location = new System.Drawing.Point(450, 104);
            this.LV_Medicaments_Autorises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LV_Medicaments_Autorises.Name = "LV_Medicaments_Autorises";
            this.LV_Medicaments_Autorises.Size = new System.Drawing.Size(363, 261);
            this.LV_Medicaments_Autorises.TabIndex = 4;
            this.LV_Medicaments_Autorises.UseCompatibleStateImageBehavior = false;
            this.LV_Medicaments_Autorises.View = System.Windows.Forms.View.Details;
            // 
            // CH_DepotLegal
            // 
            this.CH_DepotLegal.Text = "Dépot Légal";
            this.CH_DepotLegal.Width = 120;
            // 
            // CH_NomCommerce
            // 
            this.CH_NomCommerce.Text = "Nom Commercial";
            this.CH_NomCommerce.Width = 160;
            // 
            // CH_CodeFamilleMedoc
            // 
            this.CH_CodeFamilleMedoc.Text = "Code Famille";
            this.CH_CodeFamilleMedoc.Width = 120;
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(730, 370);
            this.BTN_Quitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(82, 22);
            this.BTN_Quitter.TabIndex = 6;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(200, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre de médicaments autorisés par famille";
            // 
            // NbMedicamentsAutorisesParFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(852, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.LV_Medicaments_Autorises);
            this.Controls.Add(this.LV_Famille_Autorises);
            this.Controls.Add(this.PB_LogoAutorises);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NbMedicamentsAutorisesParFamille";
            this.Text = "NbMedicamentsAutorisesParFamille";
            this.Load += new System.EventHandler(this.NbMedicamentsAutorisesParFamille_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoAutorises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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