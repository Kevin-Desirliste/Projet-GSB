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
    public partial class frmStatistique : Form
    {
        public frmStatistique()
        {
            InitializeComponent();
        }

        private void btRafraichir_Click(object sender, EventArgs e)
        {
            // Réinitialisation de la liste
            this.lvRapport.Items.Clear();

            // Charge le nombre de rapport par année
            List<List<String>> listRapportAnnee = Manager.GetRapportByYear();
            foreach (List<String> liste in listRapportAnnee)
            {
                String[] tab = { liste[0], liste[1] };
                lvRapport.Items.Add(new ListViewItem(tab));
            }

            // Charge le nombre de médecins
            List<Medecin> listMedecin = Manager.ChargerMedecins();
            int medecins = 0;
            foreach (Medecin medecin in listMedecin)
            {
                medecins += 1;
            }
            this.txtTotalMedecin.Text = medecins.ToString();

            // Charge le nombre de médicaments
            List<Medicament> listMedicament = Manager.GetChargerMedicaments();
            int medicaments = 0;
            foreach (Medicament medicament in listMedicament)
            {
                medicaments += 1;
            }
            this.txtTotalMedicament.Text = medicaments.ToString();

            // Charge le nombre de rapports
            List<Rapport> listRapport = Manager.ChargerRapports();
            int rapports = 0;
            foreach (Rapport rapport in listRapport)
            {
                rapports += 1;
            }
            this.txtTotalRapport.Text = rapports.ToString();
        }
    }
}
