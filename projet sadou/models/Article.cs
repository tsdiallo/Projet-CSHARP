using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_sadou.models
{
    class Article
    {
        private int id;
        private string Reference;
        private string Libelle;
        private double stock;
        private double Prix;
        private string Categorie;

        public int Id { get => id; set => id = value; }
        public string Reference1 { get => Reference; set => Reference = value; }
        public string Libelle1 { get => Libelle; set => Libelle = value; }
        public double Stock { get => stock; set => stock = value; }
        public double Prix1 { get => Prix; set => Prix = value; }
        public string Categorie1 { get => Categorie; set => Categorie = value; }

        public Article()
        {

        }
    }
}
