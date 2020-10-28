using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Personne
    {
        private String id;
        private String nom;
        private String prenom;
        private String adresse;

        public Personne(String id, String nom, String prenom, String adresse)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
        }

        public String GetId()
        {
            return id;
        }

        public String GetNom()
        {
            return nom;
        }

        public String GetPrenom()
        {
            return prenom;
        }

        public String GetAdresse()
        {
            return adresse;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public void SetNom(string nom)
        {
            this.nom = nom;
        }

        public void SetPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public void SetAdresse(string adresse)
        {
            this.adresse = adresse;
        }
    }
}
