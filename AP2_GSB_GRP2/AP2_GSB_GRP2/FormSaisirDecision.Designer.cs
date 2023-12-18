namespace AP2_GSB_GRP2
{
    partial class FormSaisirDecision
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvMedoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDecision = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvE = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisie de la décision d\'une étape";
            // 
            // lvMedoc
            // 
            this.lvMedoc.AutoArrange = false;
            this.lvMedoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvMedoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvMedoc.Location = new System.Drawing.Point(12, 178);
            this.lvMedoc.Name = "lvMedoc";
            this.lvMedoc.Size = new System.Drawing.Size(165, 214);
            this.lvMedoc.TabIndex = 1;
            this.lvMedoc.UseCompatibleStateImageBehavior = false;
            this.lvMedoc.View = System.Windows.Forms.View.Details;
            this.lvMedoc.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Identifiants";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Médicaments";
            this.columnHeader2.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Séléctionner un médicament :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbDecision
            // 
            this.tbDecision.Location = new System.Drawing.Point(552, 235);
            this.tbDecision.Name = "tbDecision";
            this.tbDecision.Size = new System.Drawing.Size(191, 23);
            this.tbDecision.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Soumettre la décision";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(581, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Saisir une décision :";
            // 
            // lvE
            // 
            this.lvE.AutoArrange = false;
            this.lvE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvE.Location = new System.Drawing.Point(240, 178);
            this.lvE.Name = "lvE";
            this.lvE.Size = new System.Drawing.Size(165, 214);
            this.lvE.TabIndex = 16;
            this.lvE.UseCompatibleStateImageBehavior = false;
            this.lvE.View = System.Windows.Forms.View.Details;
            this.lvE.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_2);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Identifiants";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Etapes";
            this.columnHeader4.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(240, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Séléctionner une étape :";
            // 
            // FormSaisirDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDecision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvMedoc);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "FormSaisirDecision";
            this.Text = "FormSaisirDecision";
            this.Load += new System.EventHandler(this.FormSaisirDecision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView lvMedoc;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label4;
        private TextBox tbDecision;
        private Button button1;
        private Label label2;
        private ListView lvE;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label3;
    }
}