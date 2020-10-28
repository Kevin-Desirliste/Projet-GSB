using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Medecin : Personne
    {
        private String tel;
        private int departement;
        private Specialite laSpecialite;

        public Medecin(String id, String nom, String prenom, String adresse, String tel, Specialite laSpecialite, int departement)
        : base(id, nom, prenom, adresse)
        {        
            this.tel = tel;
            this.departement = departement;
            this.laSpecialite = laSpecialite;   
      
        }

        public Medecin(String id, String nom, String prenom, String adresse, String tel, int departement)
        : base(id, nom, prenom, adresse)
        {
            this.tel = tel;
            this.departement = departement;

        }

        public String GetTel()
        {
            return tel;
        }
        
        public int GetDepartement()
        {
            return departement;
        }

        public Specialite GetSpecialite()
        {
            return this.laSpecialite;
        }

        public string toString()
        {
            return this.GetId() + "-" + this.GetNom() + " " + this.GetPrenom();
        }

        public void setSpecialite(Specialite laSpe)
        {
            this.laSpecialite = laSpe;
        }
    }
}
