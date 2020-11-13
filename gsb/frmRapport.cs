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

        private void btRechercher1_Click(object sender, EventArgs e)
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

        private void btRechercher2_Click(object sender, EventArgs e)
        {
            // récupération du médecin sélectionné
            int indexMedecin = this.cbMedecins.SelectedIndex;

            // on va rechercher les rapports grâce au manager
            List<Int32> idsDesRapports = Manager.ChercherIdsRapportsMedecin(indexMedecin);
            // on efface les éléments de la liste listRapports
            this.listRapports.Items.Clear();

            // on affiche ces ids de rapports dans la liste listRapports
            foreach (int idRapport in idsDesRapports)
            {
                // on ajoute l’idRapport aux Items de la liste listRapports :
                this.listRapports.Items.Add(idRapport);
            }
        }
    }
}
