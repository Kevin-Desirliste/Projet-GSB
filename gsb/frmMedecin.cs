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
    public partial class frmMedecin : Form
    {
        public frmMedecin()
        {
            InitializeComponent();
        }

        private void frmMedecin_Load(object sender, EventArgs e)
        {
            // On utilise la passerelle pour récupérer tous les médicaments
            List<Medecin> lesMedecins = Manager.ChargerMedecins();
            // parcours de la liste
            foreach (Medecin lesMed in lesMedecins)
            {
                // on ajoute chaque médicament aux Items de la liste listMedicaments
                this.listMedecins.Items.Add(lesMed.toString());
            }
        }

        private void listMedecins_SelectedIndexChanged(object sender, EventArgs e)
        {
            // récupération de l'indice du médicament sélectionné
            int indexMed = this.listMedecins.SelectedIndex;
            // récupération du médicament dans la classe manager
            Medecin med = Manager.GetMedecin(indexMed);
            // mise à jour des champs de texte
            this.txtId.Text = med.GetId();
            this.txtNom.Text = med.GetNom();
            this.txtPrenom.Text = med.GetPrenom();
            this.txtAdresse.Text = med.GetAdresse();
            this.txtTel.Text = med.GetTel();
            this.txtSpecialite.Text = Manager.ChargerSpecialiteDuMedecin(med).GetSpecialite();
            this.txtDepartement.Text = med.GetDepartement().ToString();
        }
    }
}
