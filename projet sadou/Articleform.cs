using projet_sadou.entity;
using projet_sadou.services;
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
    public partial class Articleform : Form
    {
        private servicesCommandeEntity service = new servicesCommandeEntity();
        private List<Article> articles;
        Article articleSelect;

        public Articleform()
        {
            InitializeComponent();
        }

        private void Articleform_Load(object sender, EventArgs e)
        {

            service.listerArt(dgvArticle);

        }

        private void ClearControl()
        {
            foreach (var control in groupBoxEnregistrement.Controls)
            {
                if (control is ListView)
                {
                    ((ListView)control).Clear();
                }

            }

        }

        

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Enregistrer2_Click(object sender, EventArgs e)
        {
            Article article = new Article()
            {
                Reference1 = Reference.Text,
                libelle1 = Libelle.Text,
                Stock = float.Parse(Stock.Text),
                Prix1 = float.Parse(Prix.Text),
                Categorie1=comboBoxCat.Text,
              
            };

            service.AddArticle(article);
            service.listerArt(dgvArticle);
            //-------------------
            ClearControl();



        }

        private void ListArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
