namespace QUIZ.Model
{
    partial class affichageDonnee
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
            this.dgv_questions = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.gb_recherche = new System.Windows.Forms.GroupBox();
            this.cb_difficulte = new System.Windows.Forms.ComboBox();
            this.label_Diff = new System.Windows.Forms.Label();
            this.label_rechercheMot = new System.Windows.Forms.Label();
            this.txt_rechercheM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).BeginInit();
            this.gb_recherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_questions
            // 
            this.dgv_questions.AllowUserToAddRows = false;
            this.dgv_questions.AllowUserToDeleteRows = false;
            this.dgv_questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_questions.Location = new System.Drawing.Point(21, 128);
            this.dgv_questions.Name = "dgv_questions";
            this.dgv_questions.ReadOnly = true;
            this.dgv_questions.Size = new System.Drawing.Size(566, 194);
            this.dgv_questions.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(607, 11);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(26, 21);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // gb_recherche
            // 
            this.gb_recherche.Controls.Add(this.cb_difficulte);
            this.gb_recherche.Controls.Add(this.label_Diff);
            this.gb_recherche.Controls.Add(this.label_rechercheMot);
            this.gb_recherche.Controls.Add(this.txt_rechercheM);
            this.gb_recherche.Location = new System.Drawing.Point(157, 12);
            this.gb_recherche.Name = "gb_recherche";
            this.gb_recherche.Size = new System.Drawing.Size(430, 83);
            this.gb_recherche.TabIndex = 11;
            this.gb_recherche.TabStop = false;
            this.gb_recherche.Text = "Recherche";
            // 
            // cb_difficulte
            // 
            this.cb_difficulte.FormattingEnabled = true;
            this.cb_difficulte.Location = new System.Drawing.Point(164, 56);
            this.cb_difficulte.Name = "cb_difficulte";
            this.cb_difficulte.Size = new System.Drawing.Size(151, 21);
            this.cb_difficulte.TabIndex = 15;
            this.cb_difficulte.SelectionChangeCommitted += new System.EventHandler(this.cb_difficulte_SelectionChangeCommitted);
            // 
            // label_Diff
            // 
            this.label_Diff.AutoSize = true;
            this.label_Diff.Location = new System.Drawing.Point(110, 59);
            this.label_Diff.Name = "label_Diff";
            this.label_Diff.Size = new System.Drawing.Size(48, 13);
            this.label_Diff.TabIndex = 14;
            this.label_Diff.Text = "Difficulté";
            // 
            // label_rechercheMot
            // 
            this.label_rechercheMot.AutoSize = true;
            this.label_rechercheMot.Location = new System.Drawing.Point(58, 22);
            this.label_rechercheMot.Name = "label_rechercheMot";
            this.label_rechercheMot.Size = new System.Drawing.Size(100, 13);
            this.label_rechercheMot.TabIndex = 13;
            this.label_rechercheMot.Text = "Recherche de mots";
            // 
            // txt_rechercheM
            // 
            this.txt_rechercheM.Location = new System.Drawing.Point(164, 19);
            this.txt_rechercheM.Name = "txt_rechercheM";
            this.txt_rechercheM.Size = new System.Drawing.Size(151, 20);
            this.txt_rechercheM.TabIndex = 12;
            this.txt_rechercheM.TextChanged += new System.EventHandler(this.txt_rechercheM_TextChanged);
            // 
            // affichageDonnee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.gb_recherche);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_questions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "affichageDonnee";
            this.Text = "affichageDonnee";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).EndInit();
            this.gb_recherche.ResumeLayout(false);
            this.gb_recherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_questions;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox gb_recherche;
        private System.Windows.Forms.TextBox txt_rechercheM;
        private System.Windows.Forms.ComboBox cb_difficulte;
        private System.Windows.Forms.Label label_Diff;
        private System.Windows.Forms.Label label_rechercheMot;
    }
}