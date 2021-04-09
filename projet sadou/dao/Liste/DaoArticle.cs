using projet_sadou.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_sadou.dao.Liste
{
    class DaoArticle:iCommande<Article>

    {
        private static List<Article> commandes = new List<Article>();

       public DaoArticle()
        {
            commandes.Add(new Article()
            {
                Reference1="250f",
                Libelle1="produit de beauté",
                Stock=1954,
                Prix1=1500,
                Categorie1="Cosmétique"
            }
            );
        }
        public static List<Article> Articles { get => Articles; set => Articles = value; }


        List<Article> iCommande<Article>.getAll()
        {
            return Articles;
        }

        bool iCommande<Article>.add(Article article)
        {
            Articles.Add(article);
            return true;
        }

        Article iCommande<Article>.getById(int id)
        {
            throw new NotImplementedException();
        }

        internal List<Article> getArticlesBycommande(Commande commande)
        {
            throw new NotImplementedException();
        }
    }
}