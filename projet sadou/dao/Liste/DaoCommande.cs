using projet_sadou.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_sadou.dao.Liste
{
    class DaoCommande:iCommande<Commande>
    {
        private static List<Commande> commandes = new List<Commande>();

        public DaoCommande()
        {
            commandes.Add(
                new Commande()
                {
                    QteCommande1 = 1500,
                    NumCommande=8564
                    
                }

                );
            commandes.Add(
                new Commande()
                {
                    QteCommande1 = 5800,
                    NumCommande=4564
                }

                );
        }

        internal void add(Commande commande)
        {
            throw new NotImplementedException();
        }

        public static List<Client> Clients { get => Clients; set => Clients = value;  }

        bool iCommande<Commande>.add(Commande commande)
        {
            commandes.Add(commande);
            return true;
        }

        internal List<Commande> getAll()
        {
            throw new NotImplementedException();
        }

        List<Commande> iCommande<Commande>.getAll()
        {
            return commandes;
        }

        Commande iCommande<Commande>.getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
