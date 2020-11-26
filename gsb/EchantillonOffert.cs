using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class EchantillonOffert
    {
        private int quantite;
        private Medicament medicament;

        public EchantillonOffert(Medicament medicament, int quantite)
        {
            this.medicament = medicament;
            this.quantite = quantite;
        }

        public Medicament GetMedicament()
        {
            return medicament;
        }

        public int GetQuantite()
        {
            return quantite;
        }
    }
}
