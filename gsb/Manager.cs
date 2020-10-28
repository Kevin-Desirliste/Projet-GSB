using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Manager
    {
        // liste des médicaments, des médecins et des familles
        private static List<Medicament> medicaments;
        private static List<Medecin> medecins;
        private static List<Famille> familles;
        private static List<Specialite> specialites;
        private static List<Visiteur> visiteurs;

        // constructeur
        public Manager()
        {
        }

        /// charge la liste des médicaments à partir de la base de données en utilisant la classe Passerelle
        /// <returns>la liste des médicaments</returns>
        public static List<Medicament> GetChargerMedicaments()
        {
            medicaments = Passerelle.GetMedicaments();
            return medicaments;
        }

        public static List<Famille> ChargerFamilles()
        {
            familles = Passerelle.GetFamilles();
            return familles;
        }

        public static List<Medecin> ChargerMedecins()
        {
            medecins = Passerelle.GetMedecin();
            return medecins;
        }

        public static List<Specialite> ChargerSpecialite()
        {
            specialites = Passerelle.GetSpecialite();
            return specialites;
        }
        
        public static List<Visiteur> ChargerVisiteurs()
        {
            visiteurs = Passerelle.GetVisiteurs();
            return visiteurs;
        }

        public static List<Int32> ChercherIdsRapportsVisiteur(int indexVisiteur)
        {
            // récupère le visiteur dans la liste visiteurs (qui a été chargée au préalable)
            Visiteur visiteur = visiteurs[indexVisiteur];
            // obtient les ids des rapports des visiteurs grâce à la Passerelle
            return Passerelle.GetIdsRapportsVisiteur(visiteur.GetId());
        }

        // permet d'obtenir une famille de la liste des familles à partir de son index
        public static Medicament GetMedicament(int index)
        {
            return medicaments[index];
        }
        
        public static Famille GetFamille(int index)
        {
            return familles[index];
        }

        public static Medecin GetMedecin(int index)
        {
            return medecins[index];
        }

        public static Specialite GetSpecialite(int index)
        {
            return specialites[index];
        }

        public static Famille GetFamilleDuMedicament(Medicament medicament)
        {
            // récupère la famille du médicament grâce à son id
            Famille laFamille = Passerelle.GetFamilleDuMedicament(medicament.GetId());
            // attribue cette famille au médicament
            medicament.SetFamille(laFamille);
            // retourne la famille
            return laFamille;
        }

        public static Specialite ChargerSpecialiteDuMedecin(Medecin medecin)
        {
            // récupère la specialite du médecin grâce à son id
            Specialite laSpe = Passerelle.GetSpecialiteDuMedecin(medecin.GetId());
            // attribue cette specialite au médecin
            medecin.setSpecialite(laSpe);
            // retourne la specialite
            return laSpe;
        }

        // permet de créer un médicament en faisant appel à la Passerelle
        public static void CreerMedicament(Medicament medicament)
        {
            // fait appel à la passerelle pour faire l'insertion
            Passerelle.InsererMedicament(medicament);
        }

        // permet de créer un médecin en faisant appel à la Passerelle
        public static void CreerMedecin(Medecin medecin)
        {
            // fait appel à la passerelle pour faire l'insertion
            Passerelle.InsererMedecin(medecin);
        }        
    }
}
