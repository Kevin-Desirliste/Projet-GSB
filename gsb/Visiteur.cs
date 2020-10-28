using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Visiteur : Personne
    {
        private String login;
        private String mdp;
        private String cp;
        private String ville;
        private DateTime dateEmbauche;

        public Visiteur(String id, String nom, String prenom, String adresse, String login, String mdp, String cp, String ville, DateTime dateEmbauche)
        : base(id, nom, prenom, adresse)
        {
            this.login = login;
            this.mdp = mdp;
            this.cp = cp;
            this.ville = ville;
            this.dateEmbauche = dateEmbauche;
        }

        public String GetCp()
        {
            return cp;
        }

        public String GetVille()
        {
            return ville;
        }

        public DateTime GetDateEmbauche()
        {
            return dateEmbauche;
        }

        public void SetCp(string cp)
        {
            this.cp = cp;
        }

        public void SetVille(string ville)
        {
            this.ville = ville;
        }

        public void SetDateEmbauche(DateTime dateEmbauche)
        {
            this.dateEmbauche = dateEmbauche;
        }

        public string toString()
        {
            return this.GetId() + "-" + this.GetNom() + " " + this.GetPrenom();
        }
    }
}
