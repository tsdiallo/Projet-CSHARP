using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_sadou.models
{
    class User
    {
        private int id;
        private string Login;
        private string Password;
        private string Nom;
        private string Prenom;
        private string Profil;

        public User()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Login1 { get => Login; set => Login = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Prenom1 { get => Prenom; set => Prenom = value; }
        public string Profil1 { get => Profil; set => Profil = value; }
    }
}
