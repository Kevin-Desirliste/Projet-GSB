using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Rapport
    {
        private int id;
        private DateTime date;
        private String motif;
        private String bilan;
        private String idVisiteur;
        private int idMedecin;
        private Visiteur visiteur;
        private Medecin medecin;
        private List<EchantillonOffert> lesEchantillonsOfferts;

        public Rapport(int id, DateTime date, String motif, String bilan, String idVisiteur, int idMedecin)
        {
            this.id = id;
            this.date = date;
            this.motif = motif;
            this.bilan = bilan;
            this.idVisiteur = idVisiteur;
            this.idMedecin = idMedecin;
        }

        public Rapport(int id, DateTime date, String motif, String bilan, Visiteur visiteur, Medecin medecin)
        {
            this.id = id;
            this.date = date;
            this.motif = motif;
            this.bilan = bilan;
            this.visiteur = visiteur;
            this.medecin = medecin;
        }

        public int GetId()
        {
            return id;
        }
        public DateTime GetDate()
        {
            return date;
        }
        public String GetMotif()
        {
            return motif;
        }
        public String GetBilan()
        {
            return bilan;
        }
        public String GetIdVisiteur()
        {
            return idVisiteur;
        }
        public int GetIdMedecin()
        {
            return idMedecin;
        }
        public Visiteur GetVisiteur()
        {
            return visiteur;
        }
        public Medecin GetMedecin()
        {
            return medecin;
        }
        public List<EchantillonOffert> GetEchantillonsOfferts()
        {
            return lesEchantillonsOfferts;
        }
        public void setVisiteur(Visiteur unVisiteur)
        {
            this.visiteur = unVisiteur;
        }
        public void setMedecin(Medecin unMedecin)
        {
            this.medecin = unMedecin;
        }
        public void setEchantillonsOfferts(List<EchantillonOffert> unEchantillonOffert)
        {
            this.lesEchantillonsOfferts = unEchantillonOffert;
        }
    }
}
