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
    public partial class frmNouveauRapport : Form
    {
        public frmNouveauRapport()
        {
            InitializeComponent();
        }

        private void frmNouveauRapport_Load(object sender, EventArgs e)
        {
            // charger la liste des visiteurs et médecins grâce au manager
            List<Visiteur> lesVisiteurs = Manager.ChargerVisiteurs();
            List<Medecin> lesMédecins = Manager.ChargerMedecins();
            List<Medicament> lesMédicaments = Manager.GetChargerMedicaments();

            // remplir la liste des visiteurs, des médecins et des médicaments
            foreach (Visiteur visiteur in lesVisiteurs)
            {
                this.cbrVisiteur.Items.Add(visiteur.toString());
            }
            foreach (Medecin medecin in lesMédecins)
            {
                this.cbrMedecin.Items.Add(medecin.toString());
            }
            foreach (Medicament medicament in lesMédicaments)
            {
                this.cbrMedicament.Items.Add(medicament.GetNomCommercial());
            }
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            String[] Offrir = { cbrMedicament.Text, txtQuantite.Text };
            ListViewItem lvi1 = new ListViewItem(Offrir);
            lvMedicaments.Items.Add(lvi1);
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection selectedIndex = this.lvMedicaments.SelectedIndices;
            foreach (int index in selectedIndex)
            {
                this.lvMedicaments.Items.RemoveAt(index);
            }
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            // récupération des médecins et visiteurs par rapport à l'index
            int medecin = Int32.Parse(Manager.GetMedecin(cbrMedecin.SelectedIndex).GetId());
            string visiteur = Manager.GetVisiteur(cbrVisiteur.SelectedIndex).GetId();
            // récupération des valeurs des champs de texte et instanciation d'un rapport
            Rapport rapport = new Rapport(0, DateTime.Parse(txtDateVisite.Text), txtMotifVisite.Text, txtBilan.Text, visiteur, medecin);
            Manager.CreerRapport(rapport);
            int idRapport = Manager.GetIdRapport(rapport);
            for (int i = 0; i < lvMedicaments.Items.Count; i++)
            {
                string newMed = lvMedicaments.Items[i].Text;
                Medicament medicament = Manager.GetMedicamentById(newMed);
                string quantite = lvMedicaments.Items[i].SubItems[1].Text;
                EchantillonOffert newEchantillon = new EchantillonOffert(medicament, int.Parse(quantite));
                Manager.CreerOffrir(idRapport, newEchantillon);
            }
            // Message de confirmation
            MessageBox.Show("Le rapport a été créé.");
        }
    }
}
