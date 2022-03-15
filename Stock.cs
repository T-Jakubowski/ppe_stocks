using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_PPE
{
    internal class Stock
    {
        private string pharmacieCode;
        private string objetCode;
        private int quantite;

        public Stock()
        {
        }

        public Stock(string pharmacieCode, string objetCode, int quantite)
        {
            this.pharmacieCode = pharmacieCode;
            this.objetCode = objetCode;
            this.quantite = quantite;
        }

        public string getPharmacieCode()
        {
            return pharmacieCode;
        }

        public void setPharmacieCode(string pharmacieCode) { this.pharmacieCode = pharmacieCode; }

        public string getObjetCode()
        {
            return objetCode;
        }

        public void setObjetCode(string objetCode) { this.objetCode = objetCode; }

        public int getQuantite()
        {
            return quantite;
        }

        public void setQuantite(int quantite) { this.quantite = quantite; }
    }
}
