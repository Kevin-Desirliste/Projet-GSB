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
    public partial class frmMedicament : Form
    {
        public frmMedicament()
        {
            InitializeComponent();
        }

        private void frmMedicament_Load(object sender, EventArgs e)
        {
            // On utilise la passerelle pour récupérer tous les médicaments
            List<Medicament> lesMedicaments = Manager.GetChargerMedicaments();
            // parcours de la liste
            foreach (Medicament med in lesMedicaments)
            {
                // on ajoute chaque médicament aux Items de la liste listMedicaments
                this.listMedicaments.Items.Add(med.ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // récupération de l'indice du médicament sélectionné
            int indexMed = this.listMedicaments.SelectedIndex;
            // récupération du médicament dans la classe manager
            Medicament med = Manager.GetMedicament(indexMed);
            // mise à jour des champs de texte
            this.txtId.Text = med.GetId();
            this.txtNomCommercial.Text = med.GetNomCommercial();
            this.txtEffets.Text = med.GetEffets();
            this.txtComposition.Text = med.GetComposition();
            this.txtContreIndications.Text = med.GetContreIndications();
            // récupération de la famille du médicament grâce au Manager
            Famille famille = Manager.GetFamilleDuMedicament(med);
            // mise à jour du champ de texte txtFamille avec le libellé de la famille
            this.txtFamille.Text = famille.GetLibelle();
        }
    }
}
