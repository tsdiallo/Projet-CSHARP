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
    class DaoClient : SqlServer, iCommande<Client>
    {
        private static List<Client> clients = new List<Client>();

        public DaoClient()
        {

        }

        bool iCommande<Client>.add(Client objet)
        {
            string sql = string.Format("");
            return base.ExecuteUpdate(sql) != 0;
        }

        List<Client> iCommande<Client>.getAll()
        {
            string sql = "select * from Client";
            List<Client> cargaisons = new List<Client>();
            DataSet ds = base.ExecuteSelect(sql);
            DataTable dt = ds.Tables[TableName];
            Client client = null;
            return clients;
        }

        Client iCommande<Client>.getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
