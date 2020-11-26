
namespace gsb
{
    partial class frmStatistique
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
            this.txtTotalRapport = new System.Windows.Forms.TextBox();
            this.txtTotalMedicament = new System.Windows.Forms.TextBox();
            this.txtTotalMedecin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lvRapport = new System.Windows.Forms.ListView();
            this.colAnnee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRapport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRafraichir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTotalRapport
            // 
            this.txtTotalRapport.Location = new System.Drawing.Point(586, 90);
            this.txtTotalRapport.Name = "txtTotalRapport";
            this.txtTotalRapport.ReadOnly = true;
            this.txtTotalRapport.Size = new System.Drawing.Size(131, 22);
            this.txtTotalRapport.TabIndex = 51;
            // 
            // txtTotalMedicament
            // 
            this.txtTotalMedicament.Location = new System.Drawing.Point(338, 90);
            this.txtTotalMedicament.Name = "txtTotalMedicament";
            this.txtTotalMedicament.ReadOnly = true;
            this.txtTotalMedicament.Size = new System.Drawing.Size(131, 22);
            this.txtTotalMedicament.TabIndex = 50;
            // 
            // txtTotalMedecin
            // 
            this.txtTotalMedecin.Location = new System.Drawing.Point(86, 90);
            this.txtTotalMedecin.Name = "txtTotalMedecin";
            this.txtTotalMedecin.ReadOnly = true;
            this.txtTotalMedecin.Size = new System.Drawing.Size(131, 22);
            this.txtTotalMedecin.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Nombre total de Rapport";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Nombre total de Médicament";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Nombre total de Médecin";
            // 
            // lvRapport
            // 
            this.lvRapport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAnnee,
            this.colRapport});
            this.lvRapport.HideSelection = false;
            this.lvRapport.Location = new System.Drawing.Point(193, 176);
            this.lvRapport.Name = "lvRapport";
            this.lvRapport.Scrollable = false;
            this.lvRapport.Size = new System.Drawing.Size(427, 216);
            this.lvRapport.TabIndex = 55;
            this.lvRapport.UseCompatibleStateImageBehavior = false;
            this.lvRapport.View = System.Windows.Forms.View.Details;
            // 
            // colAnnee
            // 
            this.colAnnee.Text = "Année";
            this.colAnnee.Width = 200;
            // 
            // colRapport
            // 
            this.colRapport.Text = "Rapports";
            this.colRapport.Width = 200;
            // 
            // btRafraichir
            // 
            this.btRafraichir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btRafraichir.Location = new System.Drawing.Point(338, 403);
            this.btRafraichir.Name = "btRafraichir";
            this.btRafraichir.Size = new System.Drawing.Size(135, 35);
            this.btRafraichir.TabIndex = 56;
            this.btRafraichir.Text = "Rafraîchir";
            this.btRafraichir.UseVisualStyleBackColor = false;
            this.btRafraichir.Click += new System.EventHandler(this.btRafraichir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Statistique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nombre total de Rapport par Année";
            // 
            // frmStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRafraichir);
            this.Controls.Add(this.lvRapport);
            this.Controls.Add(this.txtTotalRapport);
            this.Controls.Add(this.txtTotalMedicament);
            this.Controls.Add(this.txtTotalMedecin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "frmStatistique";
            this.Text = "frmStatistique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalRapport;
        private System.Windows.Forms.TextBox txtTotalMedicament;
        private System.Windows.Forms.TextBox txtTotalMedecin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvRapport;
        private System.Windows.Forms.ColumnHeader colAnnee;
        private System.Windows.Forms.ColumnHeader colRapport;
        private System.Windows.Forms.Button btRafraichir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}