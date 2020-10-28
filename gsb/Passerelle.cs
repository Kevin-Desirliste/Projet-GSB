using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

namespace gsb
{
    class Passerelle
    {
        private static DbConnection connexion = null;
        private static DbConnection GetConnexion()
        {
            if (connexion != null)
            {
                return connexion;
            }
            else
            {
                DbProviderFactory dbpf =
               DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
                connexion = dbpf.CreateConnection();
                // changez éventuellement les valeurs ci-dessous :
                connexion.ConnectionString = "server=localhost; User Id=root; database=c#";
                connexion.Open();
                return connexion;
            }
        }

        // récupère les médicaments de la base
        public static List<Medicament> GetMedicaments()
        {
            // liste de médicaments
            List<Medicament> liste = new List<Medicament>();
            DbCommand dbc = GetConnexion().CreateCommand();
            // requête SQL qui récupère tous les médicaments, triés par nom commercial
            dbc.CommandText = "SELECT * FROM medicament ORDER BY nomCommercial";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                // fait appel à MapperLigneMedicament et ajoute le médicament à la liste
                Medicament unMed = MapperLigneMedicament(reader);
                liste.Add(unMed);
            }
            reader.Close();
            return liste;
        }

        // récupère les médecins de la base
        public static List<Medecin> GetMedecin()
        {
            // liste de médecins
            List<Medecin> liste = new List<Medecin>();
            DbCommand dbc = GetConnexion().CreateCommand();
            // requête SQL qui récupère tous les médecins, triés par nom
            dbc.CommandText = "SELECT * FROM medecin ORDER BY nom";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                // fait appel à MapperLigneMedecin et ajoute le médecin à la liste
                Medecin unMed = MapperLigneMedecin(reader);
                liste.Add(unMed);
            }
            reader.Close();
            return liste;
        }

        // Récupère les familles de médicaments
        public static List<Famille> GetFamilles()
        {
            List<Famille> liste = new List<Famille>();
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT famille.* FROM famille ORDER BY libelle";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                // fait appel à MapperLigneFamille
                Famille uneFamille = MapperLigneFamille(reader);
                liste.Add(uneFamille);
            }
            reader.Close();
            return liste;
        }

        // Récupère les spécialités de la base
        public static List<Specialite> GetSpecialite()
        {
            List<Specialite> liste = new List<Specialite>();
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT specialite.* FROM specialite ORDER BY specialite";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                // fait appel à MapperLigneSpecialite
                Specialite uneSpecialite = MapperLigneSpecialite(reader);
                liste.Add(uneSpecialite);
            }
            reader.Close();
            return liste;
        }

        //Récupère les Visiteurs de la base
        public static List<Visiteur> GetVisiteurs()
        {
            List<Visiteur> liste = new List<Visiteur>();
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT visiteur.* FROM visiteur ORDER BY nom";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                // fait appel à MapperLigneVisiteur
                Visiteur unVisiteur = MapperLigneVisiteur(reader);
                liste.Add(unVisiteur);
            }
            reader.Close();
            return liste;
        }

        public static List<Int32> GetIdsRapportsVisiteur(String idVisiteur)
        {
            List<Int32> liste = new List<Int32>(); // la liste des ids
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT id FROM rapport "
            + " WHERE idVisiteur='" + idVisiteur + "' ORDER BY date DESC";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["id"];
                liste.Add(id);
            }
            reader.Close();
            return liste;
        }

        /// Crée un médicament à partir d'une ligne de résultat du jeu d'enregistrements
        private static Medicament MapperLigneMedicament(DbDataReader reader)
        {
            String id, nomCommercial, composition, effets, contreIndications;

            // récupération des informations du médicament
            id = (String)reader["id"];
            nomCommercial = (String)reader["nomCommercial"];
            composition = (String)reader["composition"];
            effets = (String)reader["effets"];
            contreIndications = (String)reader["contreIndications"];

            // instanciation des objets
            Medicament medicament = new Medicament(id, nomCommercial, composition, effets, contreIndications);
            return medicament;
        }

        /// Crée un médecin à partir d'une ligne de résultat du jeu d'enregistrements
        private static Medecin MapperLigneMedecin(DbDataReader reader)
        {
            String id, nom, prénom, adresse, tel;
            int departement;

            // récupération des informations
            id = ((int)reader["id"]).ToString();
            nom = (String)reader["nom"];
            prénom = (String)reader["prenom"];
            adresse = (String)reader["adresse"];
            tel = (String)reader["tel"];
            departement = (int)reader["departement"];

            // instanciation des objets
            Medecin medecin = new Medecin(id, nom, prénom, adresse, tel, departement);
            return medecin;
        }

        // Crée une famille à partir d'une ligne de résultat du jeu d'enregistrements
        private static Famille MapperLigneFamille(DbDataReader reader)
        {
            String id, libelle;
            id = (String)reader["id"];
            libelle = (String)reader["libelle"];
            Famille laFamille = new Famille(id, libelle);
            return laFamille;
        }

        // Crée une spécialité à partir d'une ligne de résultat du jeu d'enregistrements
        private static Specialite MapperLigneSpecialite(DbDataReader reader)
        {
            String id, specialite;
            id = (String)reader["id"];
            specialite = (String)reader["specialite"];
            Specialite laSpecialite = new Specialite(id, specialite);
            return laSpecialite;
        }

        public static Visiteur MapperLigneVisiteur(DbDataReader reader)
        {
            String id, nom, prenom, adresse, login, mdp, cp, ville;
            DateTime dateEmbauche;

            id = (String)reader["id"];
            nom = (String)reader["nom"];
            prenom = (String)reader["prenom"];
            adresse = (String)reader["adresse"];
            login = (String)reader["login"];
            mdp = (String)reader["mdp"];
            cp = (String)reader["cp"];
            ville = (String)reader["ville"];
            dateEmbauche = (DateTime)reader["dateEmbauche"];
            Visiteur visiteur = new Visiteur(id, nom, prenom, adresse, login, mdp, cp, ville, dateEmbauche);
            return visiteur;
        }

        // Récupère la famille du médicament dont l'id est passé en paramètre
        public static Famille GetFamilleDuMedicament(String idMedicament)
        {
            Famille famille = null;
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT famille.* FROM famille, medicament "
            + " WHERE medicament.idFamille = famille.id AND medicament.id = '" + idMedicament + "'";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                // fait appel à MapperLigneFamille
                famille = MapperLigneFamille(reader);
            }
            reader.Close();
            return famille;
        }

        // Récupère la spécialité du medecin
        public static Specialite GetSpecialiteDuMedecin(String idMedecin)
        {
            Specialite specialite = null;
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT specialite.* FROM specialite, medecin "
            + " WHERE medecin.idSpecialite = specialite.id AND medecin.id = '" + idMedecin + "'";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                // fait appel à MapperLigneFamille
                specialite = MapperLigneSpecialite(reader);
            }
            reader.Close();
            return specialite;
        }

        //Méthode qui permet d'insérer un nouveau médicament
        public static void InsererMedicament(Medicament medicament)
        {
            DbCommand dbc = GetConnexion().CreateCommand();
            // construction de la requête SQL insert
            dbc.CommandText = "INSERT INTO medicament VALUES ( "
            + "'" + medicament.GetId() + "',"
            + "'" + medicament.GetNomCommercial() + "',"
            + "'" + medicament.GetFamille().GetId() + "',"
            + "'" + medicament.GetComposition() + "',"
            + "'" + medicament.GetEffets() + "',"
            + "'" + medicament.GetContreIndications() + "'"
            + " )";
            // Debug : affiche la requête SQL
            MessageBox.Show(dbc.CommandText);
            // Exécution de la requête
            dbc.ExecuteNonQuery();
        }

        //Méthode qui permet d'insérer un nouveau médicament
        public static void InsererMedecin(Medecin medecin)
        {
            DbCommand dbc = GetConnexion().CreateCommand();
            // construction de la requête SQL insert
            dbc.CommandText = "INSERT INTO medecin(nom,prenom, adresse, tel, idSpecialite, departement) VALUES ( "
            + "'" + medecin.GetNom() + "',"
            + "'" + medecin.GetPrenom() + "',"
            + "'" + medecin.GetAdresse() + "',"
            + "'" + medecin.GetTel() + "',"
            + "'" + medecin.GetSpecialite().GetId() + "',"
            + "'" + medecin.GetDepartement() + "'"
            + " )";
            // Debug : affiche la requête SQL
            MessageBox.Show(dbc.CommandText);
            // Exécution de la requête
            dbc.ExecuteNonQuery();
        }
    }
}
