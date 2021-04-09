using projet_sadou.dao.bd;
using projet_sadou.dao.Liste;
using projet_sadou.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_sadou.dao.bd

{
    class DaoCommande:SqlServer ,iCommande<Commande>
    {
        private static List<Commande> commandes = new List<Commande>();

        public DaoCommande()
        {
            TableName = "Commande";
        }

        bool iCommande<Commande>.add(Commande objet)
        {
            string sql = string.Format("");
            return base.ExecuteUpdate(sql) != 0;
        }

        List<Commande> iCommande<Commande>.getAll()
        {
            string sql = "select * from Commande";
            List<Commande> cargaisons = new List<Commande>();
            DataSet ds = base.ExecuteSelect(sql);
            DataTable dt = ds.Tables[TableName];
            Commande commande = null;
            return commandes;
        }

        Commande iCommande<Commande>.getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
