namespace projet_sadou
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Profil = new System.Windows.Forms.ComboBox();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listUsers = new System.Windows.Forms.DataGridView();
            this.panelUsers = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.listUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(57, 251);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(221, 20);
            this.Prenom.TabIndex = 0;
            this.Prenom.TextChanged += new System.EventHandler(this.Prenom_TextChanged);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(57, 196);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(221, 20);
            this.Nom.TabIndex = 1;
            this.Nom.TextChanged += new System.EventHandler(this.Nom_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(57, 140);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(221, 20);
            this.Password.TabIndex = 2;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(57, 80);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(221, 20);
            this.Login.TabIndex = 3;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Profil
            // 
            this.Profil.AccessibleDescription = " Selectionner un Profil";
            this.Profil.FormattingEnabled = true;
            this.Profil.Items.AddRange(new object[] {
            "Boutiquier",
            "Marchand Ambulant",
            "Commercant"});
            this.Profil.Location = new System.Drawing.Point(57, 309);
            this.Profil.Name = "Profil";
            this.Profil.Size = new System.Drawing.Size(221, 21);
            this.Profil.TabIndex = 4;
            this.Profil.SelectedIndexChanged += new System.EventHandler(this.Profil_SelectedIndexChanged);
            // 
            // Enregistrer
            // 
            this.Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.Enregistrer.Location = new System.Drawing.Point(190, 352);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(87, 27);
            this.Enregistrer.TabIndex = 5;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = false;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(98, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enregistrement User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(554, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Liste des Users";
            // 
            // listUsers
            // 
            this.listUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUsers.Location = new System.Drawing.Point(363, 66);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(506, 448);
            this.listUsers.TabIndex = 9;
            // 
            // panelUsers
            // 
            this.panelUsers.Location = new System.Drawing.Point(0, 0);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(341, 560);
            this.panelUsers.TabIndex = 10;
            this.panelUsers.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(912, 557);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Profil);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.panelUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.ComboBox Profil;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listUsers;
        private System.Windows.Forms.GroupBox panelUsers;
    }
}

