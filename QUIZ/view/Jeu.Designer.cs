﻿namespace QUIZ
{
    partial class Jeu
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
            this.lbl_titre = new System.Windows.Forms.Label();
            this.txt_question = new System.Windows.Forms.TextBox();
            this.lbl_question = new System.Windows.Forms.Label();
            this.lbl_temps = new System.Windows.Forms.Label();
            this.txt_temps = new System.Windows.Forms.TextBox();
            this.gb_reponses = new System.Windows.Forms.GroupBox();
            this.cbox_rep5 = new System.Windows.Forms.CheckBox();
            this.cbox_rep4 = new System.Windows.Forms.CheckBox();
            this.cbox_rep3 = new System.Windows.Forms.CheckBox();
            this.cbox_rep2 = new System.Windows.Forms.CheckBox();
            this.cbox_rep1 = new System.Windows.Forms.CheckBox();
            this.txt_timer = new System.Windows.Forms.TextBox();
            this.txt_nomPrenom = new System.Windows.Forms.TextBox();
            this.txt_difficulte = new System.Windows.Forms.TextBox();
            this.lbl_joueur = new System.Windows.Forms.Label();
            this.lbl_diff = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbl_trepquestion = new System.Windows.Forms.Label();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.gb_reponses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(237, 9);
            this.lbl_titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_titre.Size = new System.Drawing.Size(264, 40);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Quizz And Test";
            // 
            // txt_question
            // 
            this.txt_question.BackColor = System.Drawing.SystemColors.Control;
            this.txt_question.Enabled = false;
            this.txt_question.Location = new System.Drawing.Point(3, 52);
            this.txt_question.Margin = new System.Windows.Forms.Padding(4);
            this.txt_question.Multiline = true;
            this.txt_question.Name = "txt_question";
            this.txt_question.ReadOnly = true;
            this.txt_question.Size = new System.Drawing.Size(352, 45);
            this.txt_question.TabIndex = 3;
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(37, 33);
            this.lbl_question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_question.Size = new System.Drawing.Size(70, 16);
            this.lbl_question.TabIndex = 5;
            this.lbl_question.Text = "Question 1";
            // 
            // lbl_temps
            // 
            this.lbl_temps.AutoSize = true;
            this.lbl_temps.Location = new System.Drawing.Point(426, 57);
            this.lbl_temps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_temps.Name = "lbl_temps";
            this.lbl_temps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_temps.Size = new System.Drawing.Size(78, 16);
            this.lbl_temps.TabIndex = 6;
            this.lbl_temps.Text = "Temps total";
            // 
            // txt_temps
            // 
            this.txt_temps.BackColor = System.Drawing.SystemColors.Control;
            this.txt_temps.Enabled = false;
            this.txt_temps.Location = new System.Drawing.Point(430, 77);
            this.txt_temps.Margin = new System.Windows.Forms.Padding(4);
            this.txt_temps.Name = "txt_temps";
            this.txt_temps.ReadOnly = true;
            this.txt_temps.Size = new System.Drawing.Size(223, 22);
            this.txt_temps.TabIndex = 7;
            // 
            // gb_reponses
            // 
            this.gb_reponses.Controls.Add(this.cbox_rep5);
            this.gb_reponses.Controls.Add(this.cbox_rep4);
            this.gb_reponses.Controls.Add(this.cbox_rep3);
            this.gb_reponses.Controls.Add(this.cbox_rep2);
            this.gb_reponses.Controls.Add(this.cbox_rep1);
            this.gb_reponses.Location = new System.Drawing.Point(3, 105);
            this.gb_reponses.Margin = new System.Windows.Forms.Padding(4);
            this.gb_reponses.Name = "gb_reponses";
            this.gb_reponses.Padding = new System.Windows.Forms.Padding(4);
            this.gb_reponses.Size = new System.Drawing.Size(238, 238);
            this.gb_reponses.TabIndex = 8;
            this.gb_reponses.TabStop = false;
            this.gb_reponses.Text = "Réponses possibles";
            // 
            // cbox_rep5
            // 
            this.cbox_rep5.AutoSize = true;
            this.cbox_rep5.Location = new System.Drawing.Point(8, 209);
            this.cbox_rep5.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_rep5.Name = "cbox_rep5";
            this.cbox_rep5.Size = new System.Drawing.Size(95, 20);
            this.cbox_rep5.TabIndex = 4;
            this.cbox_rep5.Text = "Réponse 5";
            this.cbox_rep5.UseVisualStyleBackColor = true;
            this.cbox_rep5.Click += new System.EventHandler(this.check_box_Click);
            // 
            // cbox_rep4
            // 
            this.cbox_rep4.AutoSize = true;
            this.cbox_rep4.Location = new System.Drawing.Point(8, 160);
            this.cbox_rep4.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_rep4.Name = "cbox_rep4";
            this.cbox_rep4.Size = new System.Drawing.Size(95, 20);
            this.cbox_rep4.TabIndex = 3;
            this.cbox_rep4.Text = "Réponse 4";
            this.cbox_rep4.UseVisualStyleBackColor = true;
            this.cbox_rep4.Click += new System.EventHandler(this.check_box_Click);
            // 
            // cbox_rep3
            // 
            this.cbox_rep3.AutoSize = true;
            this.cbox_rep3.Location = new System.Drawing.Point(8, 111);
            this.cbox_rep3.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_rep3.Name = "cbox_rep3";
            this.cbox_rep3.Size = new System.Drawing.Size(95, 20);
            this.cbox_rep3.TabIndex = 2;
            this.cbox_rep3.Text = "Réponse 3";
            this.cbox_rep3.UseVisualStyleBackColor = true;
            this.cbox_rep3.Click += new System.EventHandler(this.check_box_Click);
            // 
            // cbox_rep2
            // 
            this.cbox_rep2.AutoSize = true;
            this.cbox_rep2.Location = new System.Drawing.Point(8, 64);
            this.cbox_rep2.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_rep2.Name = "cbox_rep2";
            this.cbox_rep2.Size = new System.Drawing.Size(95, 20);
            this.cbox_rep2.TabIndex = 1;
            this.cbox_rep2.Text = "Réponse 2";
            this.cbox_rep2.UseVisualStyleBackColor = true;
            this.cbox_rep2.Click += new System.EventHandler(this.check_box_Click);
            // 
            // cbox_rep1
            // 
            this.cbox_rep1.AutoSize = true;
            this.cbox_rep1.Location = new System.Drawing.Point(8, 23);
            this.cbox_rep1.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_rep1.Name = "cbox_rep1";
            this.cbox_rep1.Size = new System.Drawing.Size(95, 20);
            this.cbox_rep1.TabIndex = 0;
            this.cbox_rep1.Text = "Réponse 1";
            this.cbox_rep1.UseVisualStyleBackColor = true;
            this.cbox_rep1.Click += new System.EventHandler(this.check_box_Click);
            // 
            // txt_timer
            // 
            this.txt_timer.BackColor = System.Drawing.SystemColors.Control;
            this.txt_timer.Enabled = false;
            this.txt_timer.Location = new System.Drawing.Point(430, 77);
            this.txt_timer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timer.Name = "txt_timer";
            this.txt_timer.ReadOnly = true;
            this.txt_timer.Size = new System.Drawing.Size(223, 22);
            this.txt_timer.TabIndex = 7;
            // 
            // txt_nomPrenom
            // 
            this.txt_nomPrenom.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nomPrenom.Enabled = false;
            this.txt_nomPrenom.Location = new System.Drawing.Point(429, 276);
            this.txt_nomPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomPrenom.Name = "txt_nomPrenom";
            this.txt_nomPrenom.ReadOnly = true;
            this.txt_nomPrenom.Size = new System.Drawing.Size(223, 22);
            this.txt_nomPrenom.TabIndex = 10;
            // 
            // txt_difficulte
            // 
            this.txt_difficulte.BackColor = System.Drawing.SystemColors.Control;
            this.txt_difficulte.Enabled = false;
            this.txt_difficulte.Location = new System.Drawing.Point(431, 319);
            this.txt_difficulte.Margin = new System.Windows.Forms.Padding(4);
            this.txt_difficulte.Name = "txt_difficulte";
            this.txt_difficulte.ReadOnly = true;
            this.txt_difficulte.Size = new System.Drawing.Size(223, 22);
            this.txt_difficulte.TabIndex = 11;
            // 
            // lbl_joueur
            // 
            this.lbl_joueur.AutoSize = true;
            this.lbl_joueur.Location = new System.Drawing.Point(428, 256);
            this.lbl_joueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_joueur.Name = "lbl_joueur";
            this.lbl_joueur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_joueur.Size = new System.Drawing.Size(48, 16);
            this.lbl_joueur.TabIndex = 12;
            this.lbl_joueur.Text = "Joueur";
            // 
            // lbl_diff
            // 
            this.lbl_diff.AutoSize = true;
            this.lbl_diff.Location = new System.Drawing.Point(428, 299);
            this.lbl_diff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_diff.Name = "lbl_diff";
            this.lbl_diff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_diff.Size = new System.Drawing.Size(57, 16);
            this.lbl_diff.TabIndex = 7;
            this.lbl_diff.Text = "Difficulté";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(429, 230);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(223, 23);
            this.progressBar.TabIndex = 13;
            // 
            // lbl_trepquestion
            // 
            this.lbl_trepquestion.AutoSize = true;
            this.lbl_trepquestion.Location = new System.Drawing.Point(426, 207);
            this.lbl_trepquestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trepquestion.Name = "lbl_trepquestion";
            this.lbl_trepquestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_trepquestion.Size = new System.Drawing.Size(195, 16);
            this.lbl_trepquestion.TabIndex = 14;
            this.lbl_trepquestion.Text = "temps de réponse à la question";
            // 
            // pb_img
            // 
            this.pb_img.Image = global::QUIZ.Properties.Resources.Interrogation;
            this.pb_img.Location = new System.Drawing.Point(430, 107);
            this.pb_img.Margin = new System.Windows.Forms.Padding(4);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(87, 82);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img.TabIndex = 9;
            this.pb_img.TabStop = false;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(249, 332);
            this.btn_valider.Margin = new System.Windows.Forms.Padding(4);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(78, 28);
            this.btn_valider.TabIndex = 4;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(736, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(34, 26);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 373);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_trepquestion);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lbl_diff);
            this.Controls.Add(this.lbl_joueur);
            this.Controls.Add(this.txt_difficulte);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_nomPrenom);
            this.Controls.Add(this.pb_img);
            this.Controls.Add(this.gb_reponses);
            this.Controls.Add(this.txt_timer);
            this.Controls.Add(this.txt_temps);
            this.Controls.Add(this.lbl_temps);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.lbl_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.gb_reponses.ResumeLayout(false);
            this.gb_reponses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Label lbl_temps;
        private System.Windows.Forms.TextBox txt_temps;
        private System.Windows.Forms.GroupBox gb_reponses;
        private System.Windows.Forms.CheckBox cbox_rep5;
        private System.Windows.Forms.CheckBox cbox_rep4;
        private System.Windows.Forms.CheckBox cbox_rep3;
        private System.Windows.Forms.CheckBox cbox_rep2;
        private System.Windows.Forms.CheckBox cbox_rep1;
        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.TextBox txt_timer;
        private System.Windows.Forms.TextBox txt_nomPrenom;
        private System.Windows.Forms.TextBox txt_difficulte;
        private System.Windows.Forms.Label lbl_joueur;
        private System.Windows.Forms.Label lbl_diff;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbl_trepquestion;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_close;
    }
}