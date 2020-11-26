namespace gsb
{
    partial class frmMedecin
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
            this.listMedecins = new System.Windows.Forms.ListBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSpecialite = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "liste des médecins";
            // 
            // listMedecins
            // 
            this.listMedecins.FormattingEnabled = true;
            this.listMedecins.ItemHeight = 16;
            this.listMedecins.Location = new System.Drawing.Point(32, 128);
            this.listMedecins.Name = "listMedecins";
            this.listMedecins.Size = new System.Drawing.Size(737, 180);
            this.listMedecins.TabIndex = 1;
            this.listMedecins.SelectedIndexChanged += new System.EventHandler(this.listMedecins_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(146, 363);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(176, 22);
            this.txtId.TabIndex = 2;
            // 
            // txtSpecialite
            // 
            this.txtSpecialite.Location = new System.Drawing.Point(561, 361);
            this.txtSpecialite.Name = "txtSpecialite";
            this.txtSpecialite.ReadOnly = true;
            this.txtSpecialite.Size = new System.Drawing.Size(171, 22);
            this.txtSpecialite.TabIndex = 3;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(146, 728);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(176, 22);
            this.txtTel.TabIndex = 4;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(146, 639);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.ReadOnly = true;
            this.txtAdresse.Size = new System.Drawing.Size(176, 22);
            this.txtAdresse.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(146, 551);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(176, 22);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(146, 462);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(176, 22);
            this.txtNom.TabIndex = 7;
            // 
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(561, 462);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.ReadOnly = true;
            this.txtDepartement.Size = new System.Drawing.Size(171, 22);
            this.txtDepartement.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "spécialité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "departement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "prénom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 642);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "adresse";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 731);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "tel";
            // 
            // frmMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 784);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDepartement);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSpecialite);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.listMedecins);
            this.Controls.Add(this.label1);
            this.Name = "frmMedecin";
            this.Text = "frmMedecin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMedecin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listMedecins;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSpecialite;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDepartement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}