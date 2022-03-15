using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_PPE
{
    internal class Role
    {
        public int id;
        public string nom;
        public string permission;

        public Role()
        {
        }

        public Role(int id, string nom, string permission)
        {
            this.id = id;
            this.nom = nom;
            this.permission = permission;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getNom()
        {
            return nom;
        }

        public void setNom(string nom)
        {
            this.nom=nom;
        }

        public string getPermission()
        {
            return permission;
        }

        public void setPermission(string permission)
        {
            this.permission=permission;
        }
    }
}
