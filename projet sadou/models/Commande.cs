using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_sadou.models
{
    class Commande
    {
        private double numCommande;
        private int id;
        private DateTime dateCommande;
        private double QteCommande;
        private Article article;
        private Client client;

        public double NumCommande { get => numCommande; set => numCommande = value; }
        public int Id { get => id; set => id = value; }
        public double QteCommande1 { get => QteCommande; set => QteCommande = value; }
        internal Article Article { get => article; set => article = value; }
        internal Client Client { get => client; set => client = value; }
        public DateTime DateCommande1 { get => dateCommande; set => dateCommande = value; }

        public Commande()
        {
            
        }

        public override string ToString()
        {
            return "Numéro de commande : " + NumCommande + " Date : " + DateCommande1 + " Quantitée : " + QteCommande;
        }

        
    }
}
