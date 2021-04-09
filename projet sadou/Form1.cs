using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projet_sadou.entity;
using projet_sadou.services;


namespace projet_sadou
{
    public partial class Form1 : Form
    {
        private servicesCommandeEntity service = new servicesCommandeEntity();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            service.listerUser(listUsers);
          
        }

       

        private void ClearControl()
        {
            foreach (var control in panelUsers.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }

            }

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
           
            User user = new User()
            {

                Login1 = Login.Text,
                Password1 = Password.Text,
                Nom1 = Nom.Text,
                Prenom1 = Prenom.Text,
                Profil1 = Profil.Text,
            };

            service.AddUser(user);
            service.listerUser(listUsers);
            //-------------------
            ClearControl();
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
