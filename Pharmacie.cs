using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_PPE
{
    internal class Pharmacie
    {
        private string pharmacieCode;
        private string nom;
        private string ville;

        public Pharmacie()
        {
        }

        public Pharmacie(string pharmacieCode, string nom, string ville)
        {
            this.pharmacieCode = pharmacieCode;
            this.nom = nom;
            this.ville = ville;
        }

        public string getPharmacieCode()
        {
            return pharmacieCode;
        }

        public void setPharmacieCode(string pharmacieCode)
        {
            this.pharmacieCode=pharmacieCode;
        }

        public string getNom()
        {
            return nom;
        }

        public void setNom(string nom)
        {
            this.nom=nom;
        }

        public string getVille()
        {
            return ville;
        }

        public void setVille()
        {
            this.ville=ville;
        }
    }
}
