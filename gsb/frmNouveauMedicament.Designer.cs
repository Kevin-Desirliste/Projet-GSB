namespace gsb
{
    partial class frmNouveauMedicament
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNomCommercial = new System.Windows.Forms.TextBox();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.txtEffets = new System.Windows.Forms.TextBox();
            this.txtContreIndications = new System.Windows.Forms.TextBox();
            this.btCreer = new System.Windows.Forms.Button();
            this.cbFamilles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "nouveau médicament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "nom commercial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "composition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "effets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "contre indications";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "famille";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(169, 139);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(173, 22);
            this.txtId.TabIndex = 7;
            // 
            // txtNomCommercial
            // 
            this.txtNomCommercial.Location = new System.Drawing.Point(169, 252);
            this.txtNomCommercial.Name = "txtNomCommercial";
            this.txtNomCommercial.Size = new System.Drawing.Size(173, 22);
            this.txtNomCommercial.TabIndex = 8;
            // 
            // txtComposition
            // 
            this.txtComposition.Location = new System.Drawing.Point(169, 362);
            this.txtComposition.Multiline = true;
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(173, 92);
            this.txtComposition.TabIndex = 9;
            // 
            // txtEffets
            // 
            this.txtEffets.Location = new System.Drawing.Point(589, 139);
            this.txtEffets.Multiline = true;
            this.txtEffets.Name = "txtEffets";
            this.txtEffets.Size = new System.Drawing.Size(166, 75);
            this.txtEffets.TabIndex = 10;
            // 
            // txtContreIndications
            // 
            this.txtContreIndications.Location = new System.Drawing.Point(589, 231);
            this.txtContreIndications.Multiline = true;
            this.txtContreIndications.Name = "txtContreIndications";
            this.txtContreIndications.Size = new System.Drawing.Size(166, 75);
            this.txtContreIndications.TabIndex = 11;
            // 
            // btCreer
            // 
            this.btCreer.Location = new System.Drawing.Point(36, 491);
            this.btCreer.Name = "btCreer";
            this.btCreer.Size = new System.Drawing.Size(89, 35);
            this.btCreer.TabIndex = 12;
            this.btCreer.Text = "Creer";
            this.btCreer.UseVisualStyleBackColor = true;
            this.btCreer.Click += new System.EventHandler(this.btCreer_Click);
            // 
            // cbFamilles
            // 
            this.cbFamilles.FormattingEnabled = true;
            this.cbFamilles.Location = new System.Drawing.Point(504, 365);
            this.cbFamilles.Name = "cbFamilles";
            this.cbFamilles.Size = new System.Drawing.Size(251, 24);
            this.cbFamilles.TabIndex = 13;
            // 
            // frmNouveauMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.ControlBox = false;
            this.Controls.Add(this.cbFamilles);
            this.Controls.Add(this.btCreer);
            this.Controls.Add(this.txtContreIndications);
            this.Controls.Add(this.txtEffets);
            this.Controls.Add(this.txtComposition);
            this.Controls.Add(this.txtNomCommercial);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNouveauMedicament";
            this.Text = "frmNouveauMedicament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNouveauMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNomCommercial;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.TextBox txtEffets;
        private System.Windows.Forms.TextBox txtContreIndications;
        private System.Windows.Forms.Button btCreer;
        private System.Windows.Forms.ComboBox cbFamilles;
    }
}