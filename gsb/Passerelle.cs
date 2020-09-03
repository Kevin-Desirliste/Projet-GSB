using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

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
        public static Medicament GetMedicament(String idMedicament)
        {
            Medicament medicament = null;
            DbCommand dbc = GetConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM medicament WHERE id = '" + idMedicament + "'";
            DbDataReader reader = dbc.ExecuteReader();
            if (reader.Read())
            {
                String id, nomCommercial, composition, effets, contreIndications;

                // récupération des informations du médicament
                id = (String)reader["id"];
                nomCommercial = (String)reader["nomCommercial"];
                composition = (String)reader["composition"];
                effets = (String)reader["effets"];
                contreIndications = (String)reader["contreIndications"];
                // pour la famille, on verra plus tard
                // instanciation du médicament
                medicament = new Medicament(id, nomCommercial, composition, effets,
               contreIndications);
            }
            reader.Close();
            return medicament;
        }
    }
}
