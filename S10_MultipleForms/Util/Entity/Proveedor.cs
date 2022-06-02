using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_MultipleForms.Util.Entity
{
    class Proveedor{
        private String idProv;
        private String nameProv;
        private String phoneProv;
        private String emailProv;


        public void setIDProv(String idProv)
        {
            this.idProv = idProv;
        }
        public String getIDProv() { return idProv; }

        public void setNameProv(String nameProv) { this.nameProv = nameProv; }
        public String getNameProv() { return nameProv; }    

        public void setPhoneProv(String phoneProv) { this.phoneProv = phoneProv; }
        public String getPhoneProv() { return phoneProv; }

        public void setEmailProv(String emailProv) { this.emailProv = emailProv; }
        public String getEmailProv() { return emailProv; }

    }
}
