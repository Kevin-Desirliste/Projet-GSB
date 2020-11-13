namespace gsb
{
    partial class frmRapport
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
            this.cbVisiteurs = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMedecins = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRechercher1 = new System.Windows.Forms.Button();
            this.btRechercher2 = new System.Windows.Forms.Button();
            this.listRapports = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomVisiteur = new System.Windows.Forms.TextBox();
            this.txtPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.txtAdresseMedecin = new System.Windows.Forms.TextBox();
            this.txtPrenomMedecin = new System.Windows.Forms.TextBox();
            this.txtNomMedecin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lvMedicaments = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cbVisiteurs
            // 
            this.cbVisiteurs.FormattingEnabled = true;
            this.cbVisiteurs.Location = new System.Drawing.Point(208, 28);
            this.cbVisiteurs.Name = "cbVisiteurs";
            this.cbVisiteurs.Size = new System.Drawing.Size(251, 24);
            this.cbVisiteurs.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Visiteur";
            // 
            // cbMedecins
            // 
            this.cbMedecins.FormattingEnabled = true;
            this.cbMedecins.Location = new System.Drawing.Point(208, 94);
            this.cbMedecins.Name = "cbMedecins";
            this.cbMedecins.Size = new System.Drawing.Size(251, 24);
            this.cbMedecins.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Médecin";
            // 
            // btRechercher1
            // 
            this.btRechercher1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btRechercher1.Location = new System.Drawing.Point(502, 22);
            this.btRechercher1.Name = "btRechercher1";
            this.btRechercher1.Size = new System.Drawing.Size(135, 35);
            this.btRechercher1.TabIndex = 32;
            this.btRechercher1.Text = "Rechercher";
            this.btRechercher1.UseVisualStyleBackColor = false;
            this.btRechercher1.Click += new System.EventHandler(this.btRechercher1_Click);
            // 
            // btRechercher2
            // 
            this.btRechercher2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btRechercher2.Location = new System.Drawing.Point(502, 88);
            this.btRechercher2.Name = "btRechercher2";
            this.btRechercher2.Size = new System.Drawing.Size(135, 35);
            this.btRechercher2.TabIndex = 33;
            this.btRechercher2.Text = "Rechercher";
            this.btRechercher2.UseVisualStyleBackColor = false;
            this.btRechercher2.Click += new System.EventHandler(this.btRechercher2_Click);
            // 
            // listRapports
            // 
            this.listRapports.FormattingEnabled = true;
            this.listRapports.ItemHeight = 16;
            this.listRapports.Location = new System.Drawing.Point(208, 166);
            this.listRapports.Name = "listRapports";
            this.listRapports.Size = new System.Drawing.Size(251, 84);
            this.listRapports.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "rapports de visites";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Médecin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Médecin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Bilan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Date de la visite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Motif de la visite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Prénom";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Nom";
            // 
            // txtNomVisiteur
            // 
            this.txtNomVisiteur.Location = new System.Drawing.Point(194, 310);
            this.txtNomVisiteur.Name = "txtNomVisiteur";
            this.txtNomVisiteur.Size = new System.Drawing.Size(131, 22);
            this.txtNomVisiteur.TabIndex = 43;
            // 
            // txtPrenomVisiteur
            // 
            this.txtPrenomVisiteur.Location = new System.Drawing.Point(194, 350);
            this.txtPrenomVisiteur.Name = "txtPrenomVisiteur";
            this.txtPrenomVisiteur.Size = new System.Drawing.Size(131, 22);
            this.txtPrenomVisiteur.TabIndex = 44;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(194, 389);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(131, 22);
            this.txtMotif.TabIndex = 45;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(194, 431);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(131, 22);
            this.txtDate.TabIndex = 46;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(194, 472);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(131, 22);
            this.txtBilan.TabIndex = 47;
            // 
            // txtAdresseMedecin
            // 
            this.txtAdresseMedecin.Location = new System.Drawing.Point(518, 389);
            this.txtAdresseMedecin.Name = "txtAdresseMedecin";
            this.txtAdresseMedecin.Size = new System.Drawing.Size(131, 22);
            this.txtAdresseMedecin.TabIndex = 53;
            // 
            // txtPrenomMedecin
            // 
            this.txtPrenomMedecin.Location = new System.Drawing.Point(518, 350);
            this.txtPrenomMedecin.Name = "txtPrenomMedecin";
            this.txtPrenomMedecin.Size = new System.Drawing.Size(131, 22);
            this.txtPrenomMedecin.TabIndex = 52;
            // 
            // txtNomMedecin
            // 
            this.txtNomMedecin.Location = new System.Drawing.Point(518, 310);
            this.txtNomMedecin.Name = "txtNomMedecin";
            this.txtNomMedecin.Size = new System.Drawing.Size(131, 22);
            this.txtNomMedecin.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(379, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 50;
            this.label11.Text = "Adresse";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(379, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "Prénom";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(379, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "Nom";
            // 
            // lvMedicaments
            // 
            this.lvMedicaments.HideSelection = false;
            this.lvMedicaments.Location = new System.Drawing.Point(36, 511);
            this.lvMedicaments.Name = "lvMedicaments";
            this.lvMedicaments.Size = new System.Drawing.Size(632, 216);
            this.lvMedicaments.TabIndex = 54;
            this.lvMedicaments.UseCompatibleStateImageBehavior = false;
            // 
            // frmRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 739);
            this.Controls.Add(this.lvMedicaments);
            this.Controls.Add(this.txtAdresseMedecin);
            this.Controls.Add(this.txtPrenomMedecin);
            this.Controls.Add(this.txtNomMedecin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.txtPrenomVisiteur);
            this.Controls.Add(this.txtNomVisiteur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRapports);
            this.Controls.Add(this.btRechercher2);
            this.Controls.Add(this.btRechercher1);
            this.Controls.Add(this.cbMedecins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVisiteurs);
            this.Controls.Add(this.label7);
            this.Name = "frmRapport";
            this.Text = "frmRapport";
            this.Load += new System.EventHandler(this.frmRapport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVisiteurs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMedecins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRechercher1;
        private System.Windows.Forms.Button btRechercher2;
        private System.Windows.Forms.ListBox listRapports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomVisiteur;
        private System.Windows.Forms.TextBox txtPrenomVisiteur;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.TextBox txtAdresseMedecin;
        private System.Windows.Forms.TextBox txtPrenomMedecin;
        private System.Windows.Forms.TextBox txtNomMedecin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lvMedicaments;
    }
}