namespace gsb
{
    partial class frmMedicament
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFamille = new System.Windows.Forms.TextBox();
            this.txtContreIndications = new System.Windows.Forms.TextBox();
            this.txtEffets = new System.Windows.Forms.TextBox();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.txtNomCommercial = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.listMedicaments = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.AccessibleName = "";
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtFamille);
            this.splitContainer1.Panel2.Controls.Add(this.txtContreIndications);
            this.splitContainer1.Panel2.Controls.Add(this.txtEffets);
            this.splitContainer1.Panel2.Controls.Add(this.txtComposition);
            this.splitContainer1.Panel2.Controls.Add(this.txtNomCommercial);
            this.splitContainer1.Panel2.Controls.Add(this.txtId);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.id);
            this.splitContainer1.Panel2.Controls.Add(this.listMedicaments);
            this.splitContainer1.Size = new System.Drawing.Size(800, 926);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "liste des médicaments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFamille
            // 
            this.txtFamille.Location = new System.Drawing.Point(586, 593);
            this.txtFamille.Multiline = true;
            this.txtFamille.Name = "txtFamille";
            this.txtFamille.ReadOnly = true;
            this.txtFamille.Size = new System.Drawing.Size(166, 87);
            this.txtFamille.TabIndex = 12;
            // 
            // txtContreIndications
            // 
            this.txtContreIndications.Location = new System.Drawing.Point(586, 475);
            this.txtContreIndications.Multiline = true;
            this.txtContreIndications.Name = "txtContreIndications";
            this.txtContreIndications.ReadOnly = true;
            this.txtContreIndications.Size = new System.Drawing.Size(166, 87);
            this.txtContreIndications.TabIndex = 11;
            // 
            // txtEffets
            // 
            this.txtEffets.Location = new System.Drawing.Point(586, 356);
            this.txtEffets.Multiline = true;
            this.txtEffets.Name = "txtEffets";
            this.txtEffets.ReadOnly = true;
            this.txtEffets.Size = new System.Drawing.Size(166, 90);
            this.txtEffets.TabIndex = 10;
            // 
            // txtComposition
            // 
            this.txtComposition.Location = new System.Drawing.Point(191, 593);
            this.txtComposition.Multiline = true;
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.ReadOnly = true;
            this.txtComposition.Size = new System.Drawing.Size(187, 87);
            this.txtComposition.TabIndex = 9;
            // 
            // txtNomCommercial
            // 
            this.txtNomCommercial.Location = new System.Drawing.Point(191, 475);
            this.txtNomCommercial.Name = "txtNomCommercial";
            this.txtNomCommercial.ReadOnly = true;
            this.txtNomCommercial.Size = new System.Drawing.Size(187, 22);
            this.txtNomCommercial.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(191, 359);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(187, 22);
            this.txtId.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 593);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "famille";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "contre indications";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "effets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "composition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "nom commercial";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(54, 359);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 17);
            this.id.TabIndex = 1;
            this.id.Text = "id";
            // 
            // listMedicaments
            // 
            this.listMedicaments.FormattingEnabled = true;
            this.listMedicaments.ItemHeight = 16;
            this.listMedicaments.Location = new System.Drawing.Point(46, 23);
            this.listMedicaments.Name = "listMedicaments";
            this.listMedicaments.Size = new System.Drawing.Size(706, 308);
            this.listMedicaments.TabIndex = 0;
            this.listMedicaments.SelectedIndexChanged += new System.EventHandler(this.listMedicaments_SelectedIndexChanged);
            // 
            // frmMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 926);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMedicament";
            this.Text = "frmMedicament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMedicament_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFamille;
        private System.Windows.Forms.TextBox txtContreIndications;
        private System.Windows.Forms.TextBox txtEffets;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.TextBox txtNomCommercial;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.ListBox listMedicaments;
    }
}