using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_PPE
{
    internal class Objet
    {
        private string objetCode;
        private string nom;
        private string composition;

        public Objet()
        {
        }

        public Objet(string objetCode, string nom, string composition)
        {
            this.objetCode = objetCode;
            this.nom = nom;
            this.composition = composition;
        }

        public string getObjetCode()
        {
            return objetCode;
        }

        public void setObjetCode(string objetCode)
        {
            this.objetCode=objetCode;
        }

        public string getNom()
        {
            return nom;
        }

        public void setNom(string nom)
        {
            this.nom=nom;
        }

        public string getComposition()
        {
            return composition;
        }

        public void setComposition(string composition)
        {
            this.composition=composition;
        }
    }
}
