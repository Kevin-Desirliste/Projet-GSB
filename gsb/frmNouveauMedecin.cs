using System;
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
    public partial class frmNouveauMedecin : Form
    {
        public frmNouveauMedecin()
        {
            InitializeComponent();
        }

        private void frmNouveauMedecin_Load(object sender, EventArgs e)
        {
            // charger les spécialités de medecin du manager
            List<Specialite> lesSpecialites = Manager.ChargerSpecialite();
            // Parcourir la liste des spécialités
            foreach (Specialite specialite in lesSpecialites)
            {
                // ajouter chaque spécialité aux Items de la liste cbSpécialité :
                this.cbSpecialite.Items.Add(specialite.GetSpecialite());
            }
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            // récupération des valeurs des champs de texte et instanciation d'un médecin
            Medecin nouveauMed = new Medecin("", txtNom.Text, txtPrenom.Text,
            txtAdresse.Text, txtTel.Text, Int32.Parse(txtDepartement.Text));
            // récupération de l'index sélectionné dans la liste des spécialitées
            int indexSpecialite = cbSpecialite.SelectedIndex;
            // récupération de la spécialité grâce au manager
            Specialite laSpecialite = Manager.GetSpecialite(indexSpecialite);
            // il faut attribuer cette spécialité au médecin avec setSpecialite
            nouveauMed.setSpecialite(laSpecialite);
            // on fait appel au manager pour enregistrer le médicament
            Manager.CreerMedecin(nouveauMed);
            // Message de confirmation
            MessageBox.Show("Le médecin " + nouveauMed.GetNom()+""+nouveauMed.GetPrenom() + " a été créé");
        }
    }
}
