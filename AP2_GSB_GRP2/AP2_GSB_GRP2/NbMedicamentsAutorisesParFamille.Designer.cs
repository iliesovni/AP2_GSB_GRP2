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
            this.PB_LogoAutorises = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LV_Famille_Autorises = new System.Windows.Forms.ListView();
            this.LV_Medicaments_Autorises = new System.Windows.Forms.ListView();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoAutorises)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.PB_LogoAutorises.Location = new System.Drawing.Point(-1, 0);
            this.PB_LogoAutorises.Name = "pictureBox1";
            this.PB_LogoAutorises.Size = new System.Drawing.Size(161, 105);
            this.PB_LogoAutorises.TabIndex = 0;
            this.PB_LogoAutorises.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "logo";
            // 
            // LV_Famille_Autorises
            // 
            this.LV_Famille_Autorises.Location = new System.Drawing.Point(46, 138);
            this.LV_Famille_Autorises.MultiSelect = false;
            this.LV_Famille_Autorises.Name = "LV_Famille_Autorises";
            this.LV_Famille_Autorises.Size = new System.Drawing.Size(414, 347);
            this.LV_Famille_Autorises.TabIndex = 3;
            this.LV_Famille_Autorises.UseCompatibleStateImageBehavior = false;
            this.LV_Famille_Autorises.View = System.Windows.Forms.View.Details;
            this.LV_Famille_Autorises.SelectedIndexChanged += new System.EventHandler(this.LV_Famille_Autorises_SelectedIndexChanged);
            // 
            // listView3
            // 
            this.LV_Medicaments_Autorises.Location = new System.Drawing.Point(514, 138);
            this.LV_Medicaments_Autorises.Name = "listView3";
            this.LV_Medicaments_Autorises.Size = new System.Drawing.Size(414, 347);
            this.LV_Medicaments_Autorises.TabIndex = 4;
            this.LV_Medicaments_Autorises.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(834, 494);
            this.BTN_Quitter.Name = "button2";
            this.BTN_Quitter.Size = new System.Drawing.Size(94, 29);
            this.BTN_Quitter.TabIndex = 6;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            // 
            // NbMedicamentsAutorisesParFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(974, 531);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.LV_Medicaments_Autorises);
            this.Controls.Add(this.LV_Famille_Autorises);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_LogoAutorises);
            this.Name = "NbMedicamentsAutorisesParFamille";
            this.Text = "NbMedicamentsAutorisesParFamille";
            this.Load += new System.EventHandler(this.NbMedicamentsAutorisesParFamille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoAutorises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PB_LogoAutorises;
        private Label label1;
        private ListView LV_Famille_Autorises;
        private ListView LV_Medicaments_Autorises;
        private Button BTN_Quitter;
        private ColumnHeader CH_CodeFamille_LV_FamilleAutorises;
        private ColumnHeader CH_NomFamille_LV_FamilleAutorises;
        private ColumnHeader CH_NbMedicaments_LV_FamilleAutorises;
        private ColumnHeader CH_DepotLegal_LV_MedicamentsAutorises;
        private ColumnHeader CH_NomCommercial_LV_MedicamentsAutorises;
        private ColumnHeader CH_CodeFamille_LV_MedicamentsAutorises;
    }
}