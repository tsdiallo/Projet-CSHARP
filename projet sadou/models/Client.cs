using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_sadou.models
{
    class Client
    {
        private int id;
        private string Nom;
        private string Penom;
        private string Telephone;
        private string Adresse;

        public Client()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Penom1 { get => Penom; set => Penom = value; }
        public string Telephone1 { get => Telephone; set => Telephone = value; }
        public string Adresse1 { get => Adresse; set => Adresse = value; }
    }
}
