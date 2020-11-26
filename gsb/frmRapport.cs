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
    public partial class frmRapport : Form
    {
        public frmRapport()
        {
            InitializeComponent();
        }

        private void frmRapport_Load(object sender, EventArgs e)
        {
            // charger la liste des visiteurs et médecins grâce au manager
            List<Visiteur> lesVisiteurs = Manager.ChargerVisiteurs();
            List<Medecin> lesMédecins = Manager.ChargerMedecins();

            // remplir la liste des visiteurs et médecins (cbVisiteurs & cbMédecins)
            foreach (Visiteur visiteur in lesVisiteurs)
            {
                this.cbVisiteurs.Items.Add(visiteur.toString());
            }
            foreach (Medecin medecin in lesMédecins)
            {
                this.cbMedecins.Items.Add(medecin.toString());
            }
        }

        private void btRechercherV_Click(object sender, EventArgs e)
        {
            // récupération du visiteur sélectionné
            int indexVisiteur = this.cbVisiteurs.SelectedIndex;

            // on va rechercher les rapports grâce au manager
            List<Int32> idsDesRapports = Manager.ChercherIdsRapportsVisiteur(indexVisiteur);
            // on efface les éléments de la liste listRapports
            this.listRapports.Items.Clear();

            // on affiche ces ids de rapports dans la liste listRapports
            foreach (int idRapport in idsDesRapports)
            {
                // on ajoute l’idRapport aux Items de la liste listRapports :
                this.listRapports.Items.Add(idRapport);
            }
        }

        private void btRechercherM_Click(object sender, EventArgs e)
        {
            int indexMedecin = this.cbMedecins.SelectedIndex;
            List<Int32> idsDesRapports = Manager.ChercherIdsRapportsMedecin(indexMedecin);
            this.listRapports.Items.Clear();
            foreach (int idRapport in idsDesRapports)
            {
                this.listRapports.Items.Add(idRapport);
            }
        }

        private void listRapports_SelectedIndexChanged(object sender, EventArgs e)
        {
            // récupération du rapport sélectionné dans la liste (sous forme de String)
            String idStr = this.listRapports.Text;

            // récupération de l’id du rapport
            int idRapport = Int32.Parse(this.listRapports.Text);

            // on utilise le manager pour récupérer le rapport
            Rapport rapport = Manager.ChargerRapport(idRapport);

            // affichage des infos du rapport
            this.txtNomVisiteur.Text = rapport.GetVisiteur().GetNom();
            this.txtPrenomVisiteur.Text = rapport.GetVisiteur().GetPrenom();
            this.txtMotif.Text = rapport.GetMotif();
            this.txtDate.Text = rapport.GetDate().ToString();
            this.txtBilan.Text = rapport.GetBilan();
            this.txtNomMedecin.Text = rapport.GetMedecin().GetNom();
            this.txtPrenomMedecin.Text = rapport.GetMedecin().GetPrenom();
            this.txtAdresseMedecin.Text = rapport.GetMedecin().GetAdresse();
            lvMedicaments.Items.Clear();

            // affichage des médicaments et quantité offerts par rapport
            foreach(EchantillonOffert offert in rapport.GetEchantillonsOfferts())
            {
                String[] Offrir = {offert.GetMedicament().GetNomCommercial(), offert.GetQuantite().ToString()};
                ListViewItem lvi1 = new ListViewItem(Offrir);
                lvMedicaments.Items.Add(lvi1);
            }           
        }
    }
}
