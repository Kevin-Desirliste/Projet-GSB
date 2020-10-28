using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Medicament
    {
        private String id;
        private String nomCommercial;
        private String composition;
        private String effets;
        private String contreIndications;
        private Famille famille;

        public Medicament(String id, String nomCommercial, String composition, String effets,
          String contreIndications, Famille famille)
        {
            this.id = id;
            this.nomCommercial = nomCommercial;
            this.composition = composition;
            this.effets = effets;
            this.contreIndications = contreIndications;
            this.famille = famille;
        }

        public Medicament(String id, String nomCommercial, String composition, String effets,
         String contreIndications)
        {
            this.id = id;
            this.nomCommercial = nomCommercial;
            this.composition = composition;
            this.effets = effets;
            this.contreIndications = contreIndications;
        }

        public String GetId()
        {
            return id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public String GetNomCommercial()
        {
            return nomCommercial;
        }

        public void SetNomCommercial(string nomCommercial)
        {
            this.nomCommercial = nomCommercial;
        }


        public String GetComposition()
        {
            return composition;
        }

        public void SetComposition(string composition)
        {
            this.composition = composition;
        }

        public String GetEffets()
        {
            return effets;
        }

        public void SetEffets(string effets)
        {
            this.effets = effets;
        }

        public String GetContreIndications()
        {
            return contreIndications;
        }

        public void SetContreIndications(string contreIndications)
        {
            this.contreIndications = contreIndications;
        }

        public Famille GetFamille()
        {
            return famille;
        }

        public void SetFamille(Famille famille)
        {
            this.famille = famille;
        }

        public override string ToString()
        {
            return id + " - " + nomCommercial;
        }
    }
}
