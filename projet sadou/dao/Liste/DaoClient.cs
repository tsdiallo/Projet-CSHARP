using projet_sadou.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_sadou.dao.Liste
{
    class DaoClient:iCommande<Client>
    {
        private static List<Client> clients = new List<Client>();

        public DaoClient()
        {
            clients.Add(
                new Client()
                {
                    Adresse1="thiaroye Azur",
                    Nom1="Diallo",
                    Penom1="Sadou",
                    Telephone1="774134143",
                }
                );
            new Client()
            {
                Adresse1 = "Liberté 6",
                Nom1 = "Faye",
                Penom1 = "amine",
                Telephone1="775284041"
            };
        }
       public static List<Client> Clients { get => clients; set => clients = value;  }

       public List<Client> getAll()
        {
            return Clients;
        }

        internal List<Article> getMarchandiseByCargaison(Commande commande)
        {
            throw new NotImplementedException();
        }

        public bool add(Client client)
        {
            clients.Add(client);
            return true;
        }
        public Client getById(int id)
        {
            return null;
        }
    }
}
