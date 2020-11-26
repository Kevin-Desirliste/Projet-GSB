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
                connexion.ConnectionString = "server=localhost; User Id=root; database=csharp";
                connexion.Open();
                return connexion;
            }
        }

        // Récupère les médicaments de la base
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

        public static List<Medecin> GetMedecin()
        {
            List<Medecin> liste = new List<Medecin>();
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM medecin ORDER BY nom";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                Medecin unMed = MapperLigneMedecin(reader);
                liste.Add(unMed);
            }
            reader.Close();
            return liste;
        }

        public static List<Famille> GetFamilles()
        {
            List<Famille> liste = new List<Famille>();
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT famille.* FROM famille ORDER BY libelle";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                Famille uneFamille = MapperLigneFamille(reader);
                liste.Add(uneFamille);
            }
            reader.Close();
            return liste;
        }

        public static List<Specialite> GetSpecialite()
        {
            List<Specialite> liste = new List<Specialite>();
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT specialite.* FROM specialite ORDER BY specialite";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                Specialite uneSpecialite = MapperLigneSpecialite(reader);
                liste.Add(uneSpecialite);
            }
            reader.Close();
            return liste;
        }

        public static List<Visiteur> GetVisiteurs()
        {
            List<Visiteur> liste = new List<Visiteur>();
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT visiteur.* FROM visiteur ORDER BY nom";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                Visiteur unVisiteur = MapperLigneVisiteur(reader);
                liste.Add(unVisiteur);
            }
            reader.Close();
            return liste;
        }

        public static List<Rapport> GetRapports()
        {
            List<Rapport> liste = new List<Rapport>();
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM rapport ORDER BY date";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                Rapport unRapport = MapperLigneRapport(reader);
                liste.Add(unRapport);
            }
            reader.Close();
            return liste;
        }

        // Récupère les échantillons offerts d'un rapport, à partir de son id
        public static List<EchantillonOffert> GetEchantillonsOfferts(int idRapport)
        {
            // liste des échantillons offerts
            List<EchantillonOffert> liste = new List<EchantillonOffert>();
            // requête SQL qui récupère les infos en provenance des tables offrir et medicament
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT medicament.*, offrir.quantite FROM medicament, offrir "
            + " WHERE offrir.idRapport = " + idRapport
            + " AND offrir.idMedicament = medicament.id"
            + " ORDER BY nomCommercial";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                EchantillonOffert echantillon;
                // le médicament
                Medicament unMed = MapperLigneMedicament(reader);
                // la quantité de l'échantillon
                int quantite = (int)reader["quantite"];
                // instanciation de l'échantillon offert
                echantillon = new EchantillonOffert(unMed, quantite);
                // on l'ajoute à la liste
                liste.Add(echantillon);
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

        public static List<Int32> GetIdsRapportsMedecin(String idMedecin)
        {
            List<Int32> liste = new List<Int32>();
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT id FROM rapport "
            + " WHERE idMedecin='" + idMedecin + "' ORDER BY date DESC";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["id"];
                liste.Add(id);
            }
            reader.Close();
            return liste;
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
                famille = MapperLigneFamille(reader);
            }
            reader.Close();
            return famille;
        }

        public static Specialite GetSpecialiteDuMedecin(String idMedecin)
        {
            Specialite specialite = null;
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT specialite.* FROM specialite, medecin "
            + " WHERE medecin.idSpecialite = specialite.id AND medecin.id = '" + idMedecin + "'";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                specialite = MapperLigneSpecialite(reader);
            }
            reader.Close();
            return specialite;
        }

        // Permet d’obtenir un médicament à partir de son id
        public static Medicament GetMedicament(string idMedicament)
        {
            Medicament medicament = null;
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM medicament WHERE medicament.nomCommercial = '" + idMedicament + "'";
            DbDataReader reader = dbc.ExecuteReader();
            if (reader.Read())
            {
                medicament = MapperLigneMedicament(reader);
            }
            reader.Close();
            return medicament;
        }

        public static Visiteur GetVisiteur(string idVisiteur)
        {
            Visiteur visiteur = null;

            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM visiteur WHERE id = '" + idVisiteur + "'";
            DbDataReader reader = dbc.ExecuteReader();
            if (reader.Read())
            {
                visiteur = MapperLigneVisiteur(reader);
            }
            reader.Close();
            return visiteur;
        }

        public static Medecin GetMedecin(int idMedecin)
        {
            Medecin medecin = null;

            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM medecin WHERE id = '" + idMedecin + "'";
            DbDataReader reader = dbc.ExecuteReader();
            if (reader.Read())
            {
                medecin = MapperLigneMedecin(reader);
            }
            reader.Close();
            return medecin;
        }

        public static Rapport GetRapport(int id)
        {
            Rapport rapport = null;
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM rapport WHERE rapport.id = " + id;
            DbDataReader reader = dbc.ExecuteReader();
            if (reader.Read())
            {
                rapport = MapperLigneRapport(reader);
            }
            reader.Close();
            return rapport;
        }

        public static int GetIdRapport(Rapport unRapport)
        {
            int jour = unRapport.GetDate().Day;
            int mois = unRapport.GetDate().Month;
            int annee = unRapport.GetDate().Year;

            Rapport rapport = null;
            string date = annee + "-" + mois + "-" + jour;
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM rapport WHERE date = '" + date + "' " +
                "AND idVisiteur = '" + unRapport.GetIdVisiteur() + "' AND idMedecin = '" +
                unRapport.GetIdMedecin() + "'";
            DbDataReader reader = dbc.ExecuteReader();
            if (reader.Read())
            {
                rapport = MapperLigneRapport(reader);
            }
            reader.Close();
            return rapport.GetId();
        }

        // Récupère le nombre de rapport par ans
        public static List<List<String>> GetRapportByYear()
        {
            DbCommand dbc = GetConnexion().CreateCommand();
            List<List<String>> outList = new List<List<String>>();

            dbc.CommandText = "SELECT YEAR(date), COUNT(*) FROM rapport GROUP BY YEAR(date)";
            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                List<String> inList = new List<String>();
                int year = (int)reader["YEAR(date)"];
                long nbRapport = (long)reader["COUNT(*)"];
                inList.Add(year.ToString());
                inList.Add(nbRapport.ToString());

                outList.Add(inList);
            }
            reader.Close();
            return outList;
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

        private static Medecin MapperLigneMedecin(DbDataReader reader)
        {
            String id, nom, prénom, adresse, tel;
            int departement;

            id = ((int)reader["id"]).ToString();
            nom = (String)reader["nom"];
            prénom = (String)reader["prenom"];
            adresse = (String)reader["adresse"];
            tel = (String)reader["tel"];
            departement = (int)reader["departement"];

            Medecin medecin = new Medecin(id, nom, prénom, adresse, tel, departement);
            return medecin;
        }

        private static Famille MapperLigneFamille(DbDataReader reader)
        {
            String id, libelle;

            id = (String)reader["id"];
            libelle = (String)reader["libelle"];

            Famille laFamille = new Famille(id, libelle);
            return laFamille;
        }

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

        private static Rapport MapperLigneRapport(DbDataReader reader)
        {
            int id;
            DateTime date;
            String motif, bilan, idVisiteur;
            int idMedecin;

            id = (int)reader["id"];
            date = (DateTime)reader["date"];
            motif = (String)reader["motif"];
            bilan = (String)reader["bilan"];
            idVisiteur = (String)reader["idVisiteur"];
            idMedecin = (int)reader["idMedecin"];

            Rapport rapport = new Rapport(id, date, motif, bilan, idVisiteur, idMedecin);
            return rapport;
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

        public static void InsererMedecin(Medecin medecin)
        {
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "INSERT INTO medecin(nom,prenom, adresse, tel, idSpecialite, departement) VALUES ( "
            + "'" + medecin.GetNom() + "',"
            + "'" + medecin.GetPrenom() + "',"
            + "'" + medecin.GetAdresse() + "',"
            + "'" + medecin.GetTel() + "',"
            + "'" + medecin.GetSpecialite().GetId() + "',"
            + "'" + medecin.GetDepartement() + "'"
            + " )";
            MessageBox.Show(dbc.CommandText);
            dbc.ExecuteNonQuery();
        }

        public static void InsererRapport(Rapport rapport)
        {
            int jour = rapport.GetDate().Day;
            int mois = rapport.GetDate().Month;
            int annee = rapport.GetDate().Year;
           
            string date = annee + "-" + mois + "-" + jour;

            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "INSERT INTO rapport(date, motif, bilan, idVisiteur, idMedecin) VALUES ( "
            + "'" + date + "',"
            + "'" + rapport.GetMotif() + "',"
            + "'" + rapport.GetBilan() + "',"
            + "'" + rapport.GetIdVisiteur() + "',"
            + "'" + rapport.GetIdMedecin() + "'"
            + " )";
            MessageBox.Show(dbc.CommandText);
            dbc.ExecuteNonQuery();
        }

        //Méthode qui permet d'insérer un nouveau médicament et sa quantité
        public static void InsererOffrir(int idRapport, EchantillonOffert offert)
        {
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "INSERT INTO offrir VALUES ( "
            + "'" + idRapport + "',"
            + "'" + offert.GetMedicament().GetId() + "',"
            + "'" + offert.GetQuantite() + "'"
            + " )";
            MessageBox.Show(dbc.CommandText);
            dbc.ExecuteNonQuery();
        }
    }
}
