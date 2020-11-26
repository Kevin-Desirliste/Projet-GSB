using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Manager
    {
        // liste des médicaments, des médecins, des familles etc...
        private static List<Medicament> medicaments;
        private static List<Medecin> medecins;
        private static List<Famille> familles;
        private static List<Specialite> specialites;
        private static List<Visiteur> visiteurs;
        private static List<Rapport> rapports;

        // constructeur
        public Manager()
        {
        }

        // charge la liste des médicaments à partir de la base de données en utilisant la classe Passerelle
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

        public static List<Rapport> ChargerRapports()
        {
            rapports = Passerelle.GetRapports();
            return rapports;
        }

        public static Famille ChargerFamilleDuMedicament(Medicament medicament)
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
            Specialite laSpe = Passerelle.GetSpecialiteDuMedecin(medecin.GetId());
            medecin.setSpecialite(laSpe);
            return laSpe;
        }

        // Permet d'obtenir un rapport à partir de son id
        public static Rapport ChargerRapport(int idRapport)
        {
            // utilise la passerelle pour obtenir le rapport :
            Rapport rapports = Passerelle.GetRapport(idRapport);

            //utilise la passerelle pour obtenir un visiteur :
            Visiteur visiteur = Passerelle.GetVisiteur(rapports.GetIdVisiteur());
            rapports.setVisiteur(visiteur);

            //utilise la passerelle pour obtenir un médecin :
            Medecin medecin = Passerelle.GetMedecin(rapports.GetIdMedecin());
            rapports.setMedecin(medecin);

            //utilise la passerelle pour obtenir les échantillons offerts :
            var echantillon = Passerelle.GetEchantillonsOfferts(idRapport);
            rapports.setEchantillonsOfferts(echantillon);

            return rapports;
        }

        public static List<Int32> ChercherIdsRapportsVisiteur(int indexVisiteur)
        {
            // récupère le visiteur dans la liste visiteurs (qui a été chargée au préalable)
            Visiteur visiteur = visiteurs[indexVisiteur];
            // obtient les ids des rapports des visiteurs grâce à la Passerelle
            return Passerelle.GetIdsRapportsVisiteur(visiteur.GetId());
        }

        public static List<Int32> ChercherIdsRapportsMedecin(int indexMedecin)
        {
            Medecin medecin = medecins[indexMedecin];
            return Passerelle.GetIdsRapportsMedecin(medecin.GetId());
        }

        public static int GetIdRapport(Rapport rapport)
        {
            return Passerelle.GetIdRapport(rapport);
        }

        public static List<List<String>> GetRapportByYear()
        {
            return Passerelle.GetRapportByYear();
        }

        // permet d'obtenir un médicament de la liste des médicaments à partir de son index
        public static Medicament GetMedicament(int index)
        {
            return medicaments[index];
        }
        
        public static Medicament GetMedicamentById(String id)
        {
            return Passerelle.GetMedicament(id);
        }

        public static Famille GetFamille(int index)
        {
            return familles[index];
        }

        public static Medecin GetMedecin(int index)
        {
            return medecins[index];
        }

        public static Visiteur GetVisiteur(int index)
        {
            return visiteurs[index];
        }

        public static Specialite GetSpecialite(int index)
        {
            return specialites[index];
        }

        // permet de créer un médicament en faisant appel à la Passerelle
        public static void CreerMedicament(Medicament medicament)
        {
            // fait appel à la passerelle pour faire l'insertion
            Passerelle.InsererMedicament(medicament);
        }

        public static void CreerMedecin(Medecin medecin)
        {
            Passerelle.InsererMedecin(medecin);
        }

        public static void CreerRapport(Rapport rapport)
        {
            Passerelle.InsererRapport(rapport);           
        }

        public static void CreerOffrir(int idRapport, EchantillonOffert offert)
        {
            Passerelle.InsererOffrir(idRapport, offert);
        }
    }
}
