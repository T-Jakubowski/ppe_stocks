using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_PPE
{
    internal class User
    {
        public string identifiant;
        public string nom;
        public string prenom;
        public string password;
        public int idRole;
        public string pharmacieCode;

        public User()
        {
        }

        public User(string identifiant, string nom, string prenom, string password, int idRole, string pharmacieCode)
        {
            this.identifiant = identifiant;
            this.nom = nom;
            this.prenom = prenom;
            this.password = password;
            this.idRole = idRole;
            this.pharmacieCode = pharmacieCode;
        }

        public string getIdentifiant()
        {
            return identifiant;
        }

        public void setIdentifiant(string identifiant) { this.identifiant = identifiant; }

        public string getNom()
        {
            return nom;
        }

        public void setNom(string nom) { this.nom = nom; }

        public string getPrenom()
        {
            return prenom;
        }

        public void setPrenom(string prenom)
        {
            this.prenom= prenom;
        }

        public int getIdRole()
        {
            return idRole;
        }

        public void setIdRole(int idRole) { this.idRole = idRole; }

        public string getPharmacieCode()
        {
            return pharmacieCode;
        }

        public void setPharmacieCode(string pharmacieCode) { this.pharmacieCode = pharmacieCode; }
    }
}
