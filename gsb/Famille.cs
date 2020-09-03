using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{

    class Famille
    {
        private String id;
        private String libelle;
        public Famille(String id, String libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public String GetId()
        {
            return id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public String GetLibelle()
        {
            return libelle;
        }

        public void SetLibelle(string libelle)
        {
            this.libelle = libelle;
        }

    }

}
