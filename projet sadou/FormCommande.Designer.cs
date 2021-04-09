namespace projet_sadou
{
    partial class FormCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextboxNom = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPrenom = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAdresse = new System.Windows.Forms.MaskedTextBox();
            this.Enregistrer_Client = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ADD1 = new System.Windows.Forms.Button();
            this.Search1 = new System.Windows.Forms.Button();
            this.maskedTextBoxSearch1 = new System.Windows.Forms.MaskedTextBox();
            this.Libelle = new System.Windows.Forms.MaskedTextBox();
            this.QteStock = new System.Windows.Forms.MaskedTextBox();
            this.QteCommande = new System.Windows.Forms.MaskedTextBox();
            this.ADD2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.maskedTextBoxSerch2 = new System.Windows.Forms.MaskedTextBox();
            this.Nom2 = new System.Windows.Forms.MaskedTextBox();
            this.Prenom2 = new System.Windows.Forms.MaskedTextBox();
            this.Adresse2 = new System.Windows.Forms.MaskedTextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Telephone2 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.maskedTextBoxTotal = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Adresse);
            this.groupBox1.Controls.Add(this.Telephone);
            this.groupBox1.Controls.Add(this.Prenom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Enregistrer_Client);
            this.groupBox1.Controls.Add(this.maskedTextBoxAdresse);
            this.groupBox1.Controls.Add(this.maskedTextBoxTelephone);
            this.groupBox1.Controls.Add(this.maskedTextBoxPrenom);
            this.groupBox1.Controls.Add(this.maskedTextboxNom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 615);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBoxTotal);
            this.groupBox2.Controls.Add(this.Total);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.Numero);
            this.groupBox2.Controls.Add(this.Date);
            this.groupBox2.Controls.Add(this.ADD1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(255, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 615);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enregistrement Client";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maskedTextboxNom
            // 
            this.maskedTextboxNom.Location = new System.Drawing.Point(66, 69);
            this.maskedTextboxNom.Name = "maskedTextboxNom";
            this.maskedTextboxNom.Size = new System.Drawing.Size(177, 20);
            this.maskedTextboxNom.TabIndex = 1;
            // 
            // maskedTextBoxPrenom
            // 
            this.maskedTextBoxPrenom.Location = new System.Drawing.Point(66, 120);
            this.maskedTextBoxPrenom.Name = "maskedTextBoxPrenom";
            this.maskedTextBoxPrenom.Size = new System.Drawing.Size(177, 20);
            this.maskedTextBoxPrenom.TabIndex = 2;
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(66, 184);
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(177, 20);
            this.maskedTextBoxTelephone.TabIndex = 3;
            // 
            // maskedTextBoxAdresse
            // 
            this.maskedTextBoxAdresse.Location = new System.Drawing.Point(66, 257);
            this.maskedTextBoxAdresse.Name = "maskedTextBoxAdresse";
            this.maskedTextBoxAdresse.Size = new System.Drawing.Size(177, 20);
            this.maskedTextBoxAdresse.TabIndex = 4;
            // 
            // Enregistrer_Client
            // 
            this.Enregistrer_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.Enregistrer_Client.Location = new System.Drawing.Point(143, 315);
            this.Enregistrer_Client.Name = "Enregistrer_Client";
            this.Enregistrer_Client.Size = new System.Drawing.Size(90, 29);
            this.Enregistrer_Client.TabIndex = 5;
            this.Enregistrer_Client.Text = "Enregistrer";
            this.Enregistrer_Client.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Telephone2);
            this.groupBox3.Controls.Add(this.maskedTextBoxSearch1);
            this.groupBox3.Controls.Add(this.Prenom2);
            this.groupBox3.Controls.Add(this.Search1);
            this.groupBox3.Controls.Add(this.Adresse2);
            this.groupBox3.Controls.Add(this.Nom2);
            this.groupBox3.Location = new System.Drawing.Point(0, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(589, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // ADD1
            // 
            this.ADD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ADD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD1.Location = new System.Drawing.Point(489, 82);
            this.ADD1.Name = "ADD1";
            this.ADD1.Size = new System.Drawing.Size(91, 32);
            this.ADD1.TabIndex = 3;
            this.ADD1.Text = "ADD";
            this.ADD1.UseVisualStyleBackColor = false;
            // 
            // Search1
            // 
            this.Search1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.Search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search1.ForeColor = System.Drawing.Color.Black;
            this.Search1.Location = new System.Drawing.Point(304, 15);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(93, 31);
            this.Search1.TabIndex = 0;
            this.Search1.Text = "Search";
            this.Search1.UseVisualStyleBackColor = false;
            // 
            // maskedTextBoxSearch1
            // 
            this.maskedTextBoxSearch1.Location = new System.Drawing.Point(78, 21);
            this.maskedTextBoxSearch1.Name = "maskedTextBoxSearch1";
            this.maskedTextBoxSearch1.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBoxSearch1.TabIndex = 1;
            // 
            // Libelle
            // 
            this.Libelle.Location = new System.Drawing.Point(9, 84);
            this.Libelle.Name = "Libelle";
            this.Libelle.Size = new System.Drawing.Size(132, 20);
            this.Libelle.TabIndex = 2;
            // 
            // QteStock
            // 
            this.QteStock.Location = new System.Drawing.Point(164, 84);
            this.QteStock.Name = "QteStock";
            this.QteStock.Size = new System.Drawing.Size(142, 20);
            this.QteStock.TabIndex = 3;
            // 
            // QteCommande
            // 
            this.QteCommande.Location = new System.Drawing.Point(331, 84);
            this.QteCommande.Name = "QteCommande";
            this.QteCommande.Size = new System.Drawing.Size(138, 20);
            this.QteCommande.TabIndex = 4;
            // 
            // ADD2
            // 
            this.ADD2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ADD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD2.Location = new System.Drawing.Point(489, 116);
            this.ADD2.Name = "ADD2";
            this.ADD2.Size = new System.Drawing.Size(91, 32);
            this.ADD2.TabIndex = 5;
            this.ADD2.Text = "ADD2";
            this.ADD2.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.QteCommande);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.QteStock);
            this.groupBox4.Controls.Add(this.ADD2);
            this.groupBox4.Controls.Add(this.Libelle);
            this.groupBox4.Controls.Add(this.maskedTextBoxSerch2);
            this.groupBox4.Location = new System.Drawing.Point(255, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(595, 154);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 153);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenom.Location = new System.Drawing.Point(0, 122);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(50, 15);
            this.Prenom.TabIndex = 7;
            this.Prenom.Text = "Prenom";
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telephone.Location = new System.Drawing.Point(-3, 191);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(67, 13);
            this.Telephone.TabIndex = 8;
            this.Telephone.Text = "Téléphone";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse.Location = new System.Drawing.Point(6, 257);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(52, 13);
            this.Adresse.TabIndex = 9;
            this.Adresse.Text = "Adresse";
            // 
            // maskedTextBoxSerch2
            // 
            this.maskedTextBoxSerch2.Location = new System.Drawing.Point(78, 19);
            this.maskedTextBoxSerch2.Name = "maskedTextBoxSerch2";
            this.maskedTextBoxSerch2.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBoxSerch2.TabIndex = 5;
            // 
            // Nom2
            // 
            this.Nom2.Location = new System.Drawing.Point(9, 76);
            this.Nom2.Name = "Nom2";
            this.Nom2.Size = new System.Drawing.Size(132, 20);
            this.Nom2.TabIndex = 6;
            // 
            // Prenom2
            // 
            this.Prenom2.Location = new System.Drawing.Point(164, 76);
            this.Prenom2.Name = "Prenom2";
            this.Prenom2.Size = new System.Drawing.Size(142, 20);
            this.Prenom2.TabIndex = 7;
            // 
            // Adresse2
            // 
            this.Adresse2.Location = new System.Drawing.Point(331, 76);
            this.Adresse2.Name = "Adresse2";
            this.Adresse2.Size = new System.Drawing.Size(138, 20);
            this.Adresse2.TabIndex = 8;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(19, 15);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(50, 13);
            this.Numero.TabIndex = 9;
            this.Numero.Text = "Numero";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(20, 73);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(34, 13);
            this.Date.TabIndex = 10;
            this.Date.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reference";
            // 
            // Telephone2
            // 
            this.Telephone2.AutoSize = true;
            this.Telephone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telephone2.Location = new System.Drawing.Point(6, 24);
            this.Telephone2.Name = "Telephone2";
            this.Telephone2.Size = new System.Drawing.Size(67, 13);
            this.Telephone2.TabIndex = 12;
            this.Telephone2.Text = "Telephone";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.Maroon;
            this.Total.Location = new System.Drawing.Point(371, 583);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(56, 18);
            this.Total.TabIndex = 13;
            this.Total.Text = "Total :";
            // 
            // maskedTextBoxTotal
            // 
            this.maskedTextBoxTotal.Location = new System.Drawing.Point(433, 581);
            this.maskedTextBoxTotal.Name = "maskedTextBoxTotal";
            this.maskedTextBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTotal.TabIndex = 14;
            // 
            // FormCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 610);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCommande";
            this.Text = "FormCommande";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAdresse;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrenom;
        private System.Windows.Forms.MaskedTextBox maskedTextboxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Enregistrer_Client;
        private System.Windows.Forms.Button ADD1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ADD2;
        private System.Windows.Forms.MaskedTextBox QteCommande;
        private System.Windows.Forms.MaskedTextBox QteStock;
        private System.Windows.Forms.MaskedTextBox Libelle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSearch1;
        private System.Windows.Forms.Button Search1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Telephone2;
        private System.Windows.Forms.MaskedTextBox Adresse2;
        private System.Windows.Forms.MaskedTextBox Prenom2;
        private System.Windows.Forms.MaskedTextBox Nom2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSerch2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTotal;
        private System.Windows.Forms.Label Total;
    }
}