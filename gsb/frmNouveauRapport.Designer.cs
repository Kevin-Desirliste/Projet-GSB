namespace gsb
{
    partial class frmNouveauRapport
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.btCreer = new System.Windows.Forms.Button();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbrMedicament = new System.Windows.Forms.ComboBox();
            this.lvMedicaments = new System.Windows.Forms.ListView();
            this.colMedicament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.txtDateVisite = new System.Windows.Forms.TextBox();
            this.txtMotifVisite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbrMedecin = new System.Windows.Forms.ComboBox();
            this.cbrVisiteur = new System.Windows.Forms.ComboBox();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nouveau rapport";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btAjouter);
            this.splitContainer1.Panel2.Controls.Add(this.btSupprimer);
            this.splitContainer1.Panel2.Controls.Add(this.btCreer);
            this.splitContainer1.Panel2.Controls.Add(this.txtQuantite);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.cbrMedicament);
            this.splitContainer1.Panel2.Controls.Add(this.lvMedicaments);
            this.splitContainer1.Panel2.Controls.Add(this.txtBilan);
            this.splitContainer1.Panel2.Controls.Add(this.txtDateVisite);
            this.splitContainer1.Panel2.Controls.Add(this.txtMotifVisite);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.cbrMedecin);
            this.splitContainer1.Panel2.Controls.Add(this.cbrVisiteur);
            this.splitContainer1.Size = new System.Drawing.Size(611, 721);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "nouveau rapport";
            // 
            // btCreer
            // 
            this.btCreer.Location = new System.Drawing.Point(510, 567);
            this.btCreer.Name = "btCreer";
            this.btCreer.Size = new System.Drawing.Size(89, 35);
            this.btCreer.TabIndex = 60;
            this.btCreer.Text = "Creer";
            this.btCreer.UseVisualStyleBackColor = true;
            this.btCreer.Click += new System.EventHandler(this.btCreer_Click);
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(305, 261);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(131, 22);
            this.txtQuantite.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Quantité";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Médicament";
            // 
            // cbrMedicament
            // 
            this.cbrMedicament.FormattingEnabled = true;
            this.cbrMedicament.Location = new System.Drawing.Point(306, 222);
            this.cbrMedicament.Name = "cbrMedicament";
            this.cbrMedicament.Size = new System.Drawing.Size(131, 24);
            this.cbrMedicament.TabIndex = 56;
            // 
            // lvMedicaments
            // 
            this.lvMedicaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMedicament,
            this.colQuantite});
            this.lvMedicaments.HideSelection = false;
            this.lvMedicaments.Location = new System.Drawing.Point(12, 370);
            this.lvMedicaments.Name = "lvMedicaments";
            this.lvMedicaments.Scrollable = false;
            this.lvMedicaments.Size = new System.Drawing.Size(587, 180);
            this.lvMedicaments.TabIndex = 55;
            this.lvMedicaments.UseCompatibleStateImageBehavior = false;
            this.lvMedicaments.View = System.Windows.Forms.View.Details;
            // 
            // colMedicament
            // 
            this.colMedicament.Text = "Médicaments ";
            this.colMedicament.Width = 350;
            // 
            // colQuantite
            // 
            this.colQuantite.Text = "Quantité";
            this.colQuantite.Width = 300;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(306, 161);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(131, 22);
            this.txtBilan.TabIndex = 53;
            // 
            // txtDateVisite
            // 
            this.txtDateVisite.Location = new System.Drawing.Point(306, 89);
            this.txtDateVisite.Name = "txtDateVisite";
            this.txtDateVisite.Size = new System.Drawing.Size(131, 22);
            this.txtDateVisite.TabIndex = 52;
            // 
            // txtMotifVisite
            // 
            this.txtMotifVisite.Location = new System.Drawing.Point(306, 126);
            this.txtMotifVisite.Name = "txtMotifVisite";
            this.txtMotifVisite.Size = new System.Drawing.Size(131, 22);
            this.txtMotifVisite.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Bilan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Date de la visite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Motif de la visite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Visiteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Médecin";
            // 
            // cbrMedecin
            // 
            this.cbrMedecin.FormattingEnabled = true;
            this.cbrMedecin.Location = new System.Drawing.Point(389, 34);
            this.cbrMedecin.Name = "cbrMedecin";
            this.cbrMedecin.Size = new System.Drawing.Size(199, 24);
            this.cbrMedecin.TabIndex = 1;
            // 
            // cbrVisiteur
            // 
            this.cbrVisiteur.FormattingEnabled = true;
            this.cbrVisiteur.Location = new System.Drawing.Point(89, 34);
            this.cbrVisiteur.Name = "cbrVisiteur";
            this.cbrVisiteur.Size = new System.Drawing.Size(198, 24);
            this.cbrVisiteur.TabIndex = 0;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(346, 320);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(89, 35);
            this.btSupprimer.TabIndex = 61;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(160, 320);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(89, 35);
            this.btAjouter.TabIndex = 62;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // frmNouveauRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 721);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmNouveauRapport";
            this.Text = "frmNouveauRapport";
            this.Load += new System.EventHandler(this.frmNouveauRapport_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbrMedecin;
        private System.Windows.Forms.ComboBox cbrVisiteur;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.TextBox txtDateVisite;
        private System.Windows.Forms.TextBox txtMotifVisite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbrMedicament;
        private System.Windows.Forms.ListView lvMedicaments;
        private System.Windows.Forms.ColumnHeader colMedicament;
        private System.Windows.Forms.ColumnHeader colQuantite;
        private System.Windows.Forms.Button btCreer;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btSupprimer;
    }
}