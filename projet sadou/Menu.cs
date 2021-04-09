using projet_sadou.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_sadou
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        Commande commande;
        private void Ajouter_Click(object sender, EventArgs e)
        {
            commande = new Commande();
            Commande.Show();
            
        }
        Article article;
        private void Article_Click(object sender, EventArgs e)
        {
            article = new Article();
            Commande.Show();
            
        }
    }
}
