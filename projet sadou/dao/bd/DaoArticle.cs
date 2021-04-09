using projet_sadou.dao.bd;
using projet_sadou.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using projet_sadou.dao.Liste;

namespace projet_sadou.dao.bd
{
    class DaoArticle:SqlServer ,iCommande<Article>

    {
        private static List<Article> articles = new List<Article>();

       public DaoArticle()
        {
            TableName = "Article";
        }

        List<Article> iCommande<Article>.getAll()
        {
            string sql = "select * from Commande";
            List<Article> cargaisons = new List<Article>();
            DataSet ds = base.ExecuteSelect(sql);
            DataTable dt = ds.Tables[TableName];
            Article article = null;
            return articles;
        }

        bool iCommande<Article>.add(Article objet)
        {
            string sql = string.Format("");
            return base.ExecuteUpdate(sql) != 0;
        }

        public Article getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}