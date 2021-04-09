using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_sadou.dao.Liste
{
    interface iCommande<T>
    {
        List<T> getAll();
        bool add(T objet);
        T getById(int id);
    }
}
