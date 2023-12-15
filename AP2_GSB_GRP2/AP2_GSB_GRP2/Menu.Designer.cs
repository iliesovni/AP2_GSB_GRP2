namespace AP2_GSB_GRP2
{
    partial class Menu
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
            this.btnAjoutMedicament = new System.Windows.Forms.Button();
            this.btnFormConsultationWorkflowMedicament = new System.Windows.Forms.Button();
            this.btnNbMedicamentsAutoriserParFamille = new System.Windows.Forms.Button();
            this.btnFormMedicamentsEnCoursDeValidation = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjoutMedicament
            // 
            this.btnAjoutMedicament.Location = new System.Drawing.Point(87, 112);
            this.btnAjoutMedicament.Name = "btnAjoutMedicament";
            this.btnAjoutMedicament.Size = new System.Drawing.Size(189, 29);
            this.btnAjoutMedicament.TabIndex = 0;
            this.btnAjoutMedicament.Text = "FormAjouterMedicament";
            this.btnAjoutMedicament.UseVisualStyleBackColor = true;
            this.btnAjoutMedicament.Click += new System.EventHandler(this.btnAjoutMedicament_Click);
            // 
            // btnFormConsultationWorkflowMedicament
            // 
            this.btnFormConsultationWorkflowMedicament.Location = new System.Drawing.Point(312, 112);
            this.btnFormConsultationWorkflowMedicament.Name = "btnFormConsultationWorkflowMedicament";
            this.btnFormConsultationWorkflowMedicament.Size = new System.Drawing.Size(288, 29);
            this.btnFormConsultationWorkflowMedicament.TabIndex = 1;
            this.btnFormConsultationWorkflowMedicament.Text = "FormConsultationWorkflowMedicament";
            this.btnFormConsultationWorkflowMedicament.UseVisualStyleBackColor = true;
            this.btnFormConsultationWorkflowMedicament.Click += new System.EventHandler(this.btnFormConsultationWorkflowMedicament_Click);
            // 
            // btnNbMedicamentsAutoriserParFamille
            // 
            this.btnNbMedicamentsAutoriserParFamille.Location = new System.Drawing.Point(87, 183);
            this.btnNbMedicamentsAutoriserParFamille.Name = "btnNbMedicamentsAutoriserParFamille";
            this.btnNbMedicamentsAutoriserParFamille.Size = new System.Drawing.Size(293, 29);
            this.btnNbMedicamentsAutoriserParFamille.TabIndex = 2;
            this.btnNbMedicamentsAutoriserParFamille.Text = "FormNbMedicamentsAutoriserParFamille";
            this.btnNbMedicamentsAutoriserParFamille.UseVisualStyleBackColor = true;
            this.btnNbMedicamentsAutoriserParFamille.Click += new System.EventHandler(this.btnNbMedicamentsAutoriserParFamille_Click);
            // 
            // btnFormMedicamentsEnCoursDeValidation
            // 
            this.btnFormMedicamentsEnCoursDeValidation.Location = new System.Drawing.Point(87, 262);
            this.btnFormMedicamentsEnCoursDeValidation.Name = "btnFormMedicamentsEnCoursDeValidation";
            this.btnFormMedicamentsEnCoursDeValidation.Size = new System.Drawing.Size(293, 29);
            this.btnFormMedicamentsEnCoursDeValidation.TabIndex = 3;
            this.btnFormMedicamentsEnCoursDeValidation.Text = "FormMedicamentsEnCoursDeValidation";
            this.btnFormMedicamentsEnCoursDeValidation.UseVisualStyleBackColor = true;
            this.btnFormMedicamentsEnCoursDeValidation.Click += new System.EventHandler(this.btnFormMedicamentsEnCoursDeValidation_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(506, 348);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(94, 29);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnFormMedicamentsEnCoursDeValidation);
            this.Controls.Add(this.btnNbMedicamentsAutoriserParFamille);
            this.Controls.Add(this.btnFormConsultationWorkflowMedicament);
            this.Controls.Add(this.btnAjoutMedicament);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAjoutMedicament;
        private Button btnFormConsultationWorkflowMedicament;
        private Button btnNbMedicamentsAutoriserParFamille;
        private Button btnFormMedicamentsEnCoursDeValidation;
        private Button btnQuitter;
    }
}