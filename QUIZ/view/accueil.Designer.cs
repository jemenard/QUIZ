namespace QUIZ
{
    partial class accueil
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
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.cb_difficulte = new System.Windows.Forms.ComboBox();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(409, 332);
            this.btn_valider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(100, 28);
            this.btn_valider.TabIndex = 1;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(165, 139);
            this.lbl_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(60, 16);
            this.lbl_prenom.TabIndex = 3;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(165, 79);
            this.lbl_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(42, 16);
            this.lbl_nom.TabIndex = 4;
            this.lbl_nom.Text = "Nom :";
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nom.Location = new System.Drawing.Point(343, 74);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(223, 22);
            this.txt_nom.TabIndex = 5;
            // 
            // txt_prenom
            // 
            this.txt_prenom.BackColor = System.Drawing.SystemColors.Control;
            this.txt_prenom.Location = new System.Drawing.Point(343, 131);
            this.txt_prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(223, 22);
            this.txt_prenom.TabIndex = 6;
            // 
            // cb_difficulte
            // 
            this.cb_difficulte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_difficulte.FormattingEnabled = true;
            this.cb_difficulte.Location = new System.Drawing.Point(343, 280);
            this.cb_difficulte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_difficulte.Name = "cb_difficulte";
            this.cb_difficulte.Size = new System.Drawing.Size(223, 24);
            this.cb_difficulte.TabIndex = 7;
            this.cb_difficulte.SelectedIndexChanged += new System.EventHandler(this.cb_difficulte_SelectedIndexChanged);
            // 
            // lbl_difficulte
            // 
            this.lbl_difficulte.AutoSize = true;
            this.lbl_difficulte.Location = new System.Drawing.Point(165, 289);
            this.lbl_difficulte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(63, 16);
            this.lbl_difficulte.TabIndex = 8;
            this.lbl_difficulte.Text = "Difficulté :";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(736, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(34, 26);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 373);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_difficulte);
            this.Controls.Add(this.cb_difficulte);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.btn_valider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.ComboBox cb_difficulte;
        private System.Windows.Forms.Label lbl_difficulte;
        private System.Windows.Forms.Button btn_close;
    }
}

