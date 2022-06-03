using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_MultipleForms.Util.Entity
{
    class Cliente{
        private String firstNameClient;
        private String lastNameClient;
        private String DNIClient;
        private String phoneCliente;
        private String direccionClient;
        private String emailClient;

        public void setFirstNameClient(String firstNameClient) { this.firstNameClient = firstNameClient; }
        public String getFirstNameClient() { return firstNameClient; }

        public void setLastNameClient(String lastNameClient) { this.lastNameClient = lastNameClient; }
        public String getLastNameClient() { return lastNameClient; }

        public void setDNIClient(String DNIClient) { this.DNIClient = DNIClient; }
        public String getDNIClient() { return DNIClient; }

        public void setPhoneClient(String phoneCliente) { this.phoneCliente = phoneCliente; }
        public String getPhoneClient() { return phoneCliente; }

        public void setDireccionClient(String direccionClient) { this.direccionClient = direccionClient; }
        public String getDireccionClient() { return direccionClient; }

        public void setEmailClient(String emailClient) { this.emailClient = emailClient; }
        public String getEmailClient() { return emailClient; }

    }
}
