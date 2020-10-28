using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb
{
    class Specialite
    {
        private String id;
        private String specialite;

        public Specialite(String id, String specialite)
        {
            this.id = id;
            this.specialite = specialite;
        }

        public String GetId()
        {
            return id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public String GetSpecialite()
        {
            return specialite;
        }

        public void SetSpecialite(string specialite)
        {
            this.specialite = specialite;
        }
    }
}
