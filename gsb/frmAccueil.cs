﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btQuitter_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI(); // ferme le formulaire actif
            RendVisible(false); // rend invisibles les composants de "frmAccueil"
            frmMedicament f = new frmMedicament(); // créer une instance de "frmMedicament"
            f.MdiParent = this; // le formulaire MDI parent est l'instance en cours (this) // de "frmAccueil"
            f.Show(); // montrer le nouveau formulaire
        }

        private void FermerMDI()
        {
            Form c;
            c = this.ActiveMdiChild; // récupère le formulaire actif
            if (c != null) // s’il existe
                c.Close(); // on le ferme
        }

        private void RendVisible(bool val) // val vaut true ou false
        {
            pictureBox1.Visible = val; // la propriété Visible passe à Vrai ou Faux
            btQuitter.Visible = val;
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FermerMDI(); 
            RendVisible(false);
            frmMedecin f = new frmMedecin(); 
            f.MdiParent = this; 
            f.Show(); 
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmNouveauMedicament f = new frmNouveauMedicament();
            f.MdiParent = this;
            f.Show();
        }

        private void gérerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmNouveauMedecin f = new frmNouveauMedecin();
            f.MdiParent = this;
            f.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmRapport r = new frmRapport();
            r.MdiParent = this;
            r.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmNouveauRapport r = new frmNouveauRapport();
            r.MdiParent = this;
            r.Show();
        }

        private void statistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI();
            RendVisible(false);
            frmStatistique s = new frmStatistique();
            s.MdiParent = this;
            s.Show();
        }
    }
}
