namespace projet_sadou
{
    partial class Articleform
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
            this.groupBoxEnregistrement = new System.Windows.Forms.GroupBox();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.Enregistrer2 = new System.Windows.Forms.Button();
            this.maskedTextBoxPrix = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxstock = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLibel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRef = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Categorie = new System.Windows.Forms.Label();
            this.Prix = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.Label();
            this.Libelle = new System.Windows.Forms.Label();
            this.Reference = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvArticle = new System.Windows.Forms.DataGridView();
            this.groupBoxEnregistrement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEnregistrement
            // 
            this.groupBoxEnregistrement.Controls.Add(this.comboBoxCat);
            this.groupBoxEnregistrement.Controls.Add(this.Enregistrer2);
            this.groupBoxEnregistrement.Controls.Add(this.maskedTextBoxPrix);
            this.groupBoxEnregistrement.Controls.Add(this.maskedTextBoxstock);
            this.groupBoxEnregistrement.Controls.Add(this.maskedTextBoxLibel);
            this.groupBoxEnregistrement.Controls.Add(this.maskedTextBoxRef);
            this.groupBoxEnregistrement.Controls.Add(this.label6);
            this.groupBoxEnregistrement.Controls.Add(this.Categorie);
            this.groupBoxEnregistrement.Controls.Add(this.Prix);
            this.groupBoxEnregistrement.Controls.Add(this.Stock);
            this.groupBoxEnregistrement.Controls.Add(this.Libelle);
            this.groupBoxEnregistrement.Controls.Add(this.Reference);
            this.groupBoxEnregistrement.Location = new System.Drawing.Point(0, 2);
            this.groupBoxEnregistrement.Name = "groupBoxEnregistrement";
            this.groupBoxEnregistrement.Size = new System.Drawing.Size(275, 573);
            this.groupBoxEnregistrement.TabIndex = 0;
            this.groupBoxEnregistrement.TabStop = false;
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Items.AddRange(new object[] {
            "com",
            "electromenager",
            "beauté"});
            this.comboBoxCat.Location = new System.Drawing.Point(98, 260);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(153, 21);
            this.comboBoxCat.TabIndex = 13;
            // 
            // Enregistrer2
            // 
            this.Enregistrer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.Enregistrer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrer2.Location = new System.Drawing.Point(165, 311);
            this.Enregistrer2.Name = "Enregistrer2";
            this.Enregistrer2.Size = new System.Drawing.Size(86, 36);
            this.Enregistrer2.TabIndex = 12;
            this.Enregistrer2.Text = "Enregistrer";
            this.Enregistrer2.UseVisualStyleBackColor = false;
            this.Enregistrer2.Click += new System.EventHandler(this.Enregistrer2_Click);
            // 
            // maskedTextBoxPrix
            // 
            this.maskedTextBoxPrix.Location = new System.Drawing.Point(98, 215);
            this.maskedTextBoxPrix.Name = "maskedTextBoxPrix";
            this.maskedTextBoxPrix.Size = new System.Drawing.Size(153, 20);
            this.maskedTextBoxPrix.TabIndex = 10;
            // 
            // maskedTextBoxstock
            // 
            this.maskedTextBoxstock.Location = new System.Drawing.Point(98, 167);
            this.maskedTextBoxstock.Name = "maskedTextBoxstock";
            this.maskedTextBoxstock.Size = new System.Drawing.Size(153, 20);
            this.maskedTextBoxstock.TabIndex = 9;
            // 
            // maskedTextBoxLibel
            // 
            this.maskedTextBoxLibel.Location = new System.Drawing.Point(98, 121);
            this.maskedTextBoxLibel.Name = "maskedTextBoxLibel";
            this.maskedTextBoxLibel.Size = new System.Drawing.Size(153, 20);
            this.maskedTextBoxLibel.TabIndex = 8;
            // 
            // maskedTextBoxRef
            // 
            this.maskedTextBoxRef.Location = new System.Drawing.Point(98, 77);
            this.maskedTextBoxRef.Name = "maskedTextBoxRef";
            this.maskedTextBoxRef.Size = new System.Drawing.Size(153, 20);
            this.maskedTextBoxRef.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label6.Location = new System.Drawing.Point(56, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Enregistrement Article";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Categorie
            // 
            this.Categorie.AutoSize = true;
            this.Categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorie.Location = new System.Drawing.Point(6, 268);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(61, 13);
            this.Categorie.TabIndex = 1;
            this.Categorie.Text = "Categorie";
            // 
            // Prix
            // 
            this.Prix.AutoSize = true;
            this.Prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prix.Location = new System.Drawing.Point(6, 215);
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(28, 13);
            this.Prix.TabIndex = 2;
            this.Prix.Text = "Prix";
            this.Prix.Click += new System.EventHandler(this.label2_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.Location = new System.Drawing.Point(6, 170);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(40, 13);
            this.Stock.TabIndex = 3;
            this.Stock.Text = "Stock";
            // 
            // Libelle
            // 
            this.Libelle.AutoSize = true;
            this.Libelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Libelle.Location = new System.Drawing.Point(6, 121);
            this.Libelle.Name = "Libelle";
            this.Libelle.Size = new System.Drawing.Size(44, 13);
            this.Libelle.TabIndex = 4;
            this.Libelle.Text = "Libelle";
            // 
            // Reference
            // 
            this.Reference.AutoSize = true;
            this.Reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reference.Location = new System.Drawing.Point(6, 77);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(66, 13);
            this.Reference.TabIndex = 5;
            this.Reference.Text = "Reference";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label7.Location = new System.Drawing.Point(521, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Gestion Commercial";
            // 
            // dgvArticle
            // 
            this.dgvArticle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticle.Location = new System.Drawing.Point(293, 79);
            this.dgvArticle.Name = "dgvArticle";
            this.dgvArticle.Size = new System.Drawing.Size(632, 496);
            this.dgvArticle.TabIndex = 8;
            // 
            // Articleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(926, 575);
            this.Controls.Add(this.dgvArticle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBoxEnregistrement);
            this.Name = "Articleform";
            this.Text = "Articleform";
            this.Load += new System.EventHandler(this.Articleform_Load);
            this.groupBoxEnregistrement.ResumeLayout(false);
            this.groupBoxEnregistrement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEnregistrement;
        private System.Windows.Forms.Button Enregistrer2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrix;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxstock;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLibel;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRef;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Categorie;
        private System.Windows.Forms.Label Prix;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Label Libelle;
        private System.Windows.Forms.Label Reference;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.DataGridView dgvArticle;
    }
}