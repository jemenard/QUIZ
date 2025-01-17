namespace QUIZ
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
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_q1 = new System.Windows.Forms.Label();
            this.lbl_temps = new System.Windows.Forms.Label();
            this.txt_temps = new System.Windows.Forms.TextBox();
            this.gb_reponses = new System.Windows.Forms.GroupBox();
            this.cbox_rep1 = new System.Windows.Forms.CheckBox();
            this.cbox_rep2 = new System.Windows.Forms.CheckBox();
            this.cbox_rep3 = new System.Windows.Forms.CheckBox();
            this.cbox_rep4 = new System.Windows.Forms.CheckBox();
            this.cbox_rep5 = new System.Windows.Forms.CheckBox();
            this.gb_reponses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(247, 39);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_titre.Size = new System.Drawing.Size(215, 38);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Quizz And Test";
            // 
            // txt_question
            // 
            this.txt_question.BackColor = System.Drawing.SystemColors.Control;
            this.txt_question.Enabled = false;
            this.txt_question.Location = new System.Drawing.Point(28, 118);
            this.txt_question.Multiline = true;
            this.txt_question.Name = "txt_question";
            this.txt_question.Size = new System.Drawing.Size(546, 79);
            this.txt_question.TabIndex = 3;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(270, 415);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 4;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // lbl_q1
            // 
            this.lbl_q1.AutoSize = true;
            this.lbl_q1.Location = new System.Drawing.Point(53, 102);
            this.lbl_q1.Name = "lbl_q1";
            this.lbl_q1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_q1.Size = new System.Drawing.Size(58, 13);
            this.lbl_q1.TabIndex = 5;
            this.lbl_q1.Text = "Question 1";
            // 
            // lbl_temps
            // 
            this.lbl_temps.AutoSize = true;
            this.lbl_temps.Location = new System.Drawing.Point(617, 54);
            this.lbl_temps.Name = "lbl_temps";
            this.lbl_temps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_temps.Size = new System.Drawing.Size(62, 13);
            this.lbl_temps.TabIndex = 6;
            this.lbl_temps.Text = "Temps total";
            // 
            // txt_temps
            // 
            this.txt_temps.BackColor = System.Drawing.SystemColors.Control;
            this.txt_temps.Location = new System.Drawing.Point(620, 70);
            this.txt_temps.Name = "txt_temps";
            this.txt_temps.Size = new System.Drawing.Size(168, 20);
            this.txt_temps.TabIndex = 7;
            // 
            // gb_reponses
            // 
            this.gb_reponses.Controls.Add(this.cbox_rep5);
            this.gb_reponses.Controls.Add(this.cbox_rep4);
            this.gb_reponses.Controls.Add(this.cbox_rep3);
            this.gb_reponses.Controls.Add(this.cbox_rep2);
            this.gb_reponses.Controls.Add(this.cbox_rep1);
            this.gb_reponses.Location = new System.Drawing.Point(28, 203);
            this.gb_reponses.Name = "gb_reponses";
            this.gb_reponses.Size = new System.Drawing.Size(546, 206);
            this.gb_reponses.TabIndex = 8;
            this.gb_reponses.TabStop = false;
            this.gb_reponses.Text = "Réponses possibles";
            // 
            // cbox_rep1
            // 
            this.cbox_rep1.AutoSize = true;
            this.cbox_rep1.Location = new System.Drawing.Point(6, 19);
            this.cbox_rep1.Name = "cbox_rep1";
            this.cbox_rep1.Size = new System.Drawing.Size(78, 17);
            this.cbox_rep1.TabIndex = 0;
            this.cbox_rep1.Text = "Réponse 1";
            this.cbox_rep1.UseVisualStyleBackColor = true;
            // 
            // cbox_rep2
            // 
            this.cbox_rep2.AutoSize = true;
            this.cbox_rep2.Location = new System.Drawing.Point(6, 52);
            this.cbox_rep2.Name = "cbox_rep2";
            this.cbox_rep2.Size = new System.Drawing.Size(78, 17);
            this.cbox_rep2.TabIndex = 1;
            this.cbox_rep2.Text = "Réponse 2";
            this.cbox_rep2.UseVisualStyleBackColor = true;
            // 
            // cbox_rep3
            // 
            this.cbox_rep3.AutoSize = true;
            this.cbox_rep3.Location = new System.Drawing.Point(6, 90);
            this.cbox_rep3.Name = "cbox_rep3";
            this.cbox_rep3.Size = new System.Drawing.Size(78, 17);
            this.cbox_rep3.TabIndex = 2;
            this.cbox_rep3.Text = "Réponse 3";
            this.cbox_rep3.UseVisualStyleBackColor = true;
            // 
            // cbox_rep4
            // 
            this.cbox_rep4.AutoSize = true;
            this.cbox_rep4.Location = new System.Drawing.Point(6, 130);
            this.cbox_rep4.Name = "cbox_rep4";
            this.cbox_rep4.Size = new System.Drawing.Size(78, 17);
            this.cbox_rep4.TabIndex = 3;
            this.cbox_rep4.Text = "Réponse 4";
            this.cbox_rep4.UseVisualStyleBackColor = true;
            // 
            // cbox_rep5
            // 
            this.cbox_rep5.AutoSize = true;
            this.cbox_rep5.Location = new System.Drawing.Point(6, 170);
            this.cbox_rep5.Name = "cbox_rep5";
            this.cbox_rep5.Size = new System.Drawing.Size(78, 17);
            this.cbox_rep5.TabIndex = 4;
            this.cbox_rep5.Text = "Réponse 5";
            this.cbox_rep5.UseVisualStyleBackColor = true;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_reponses);
            this.Controls.Add(this.txt_temps);
            this.Controls.Add(this.lbl_temps);
            this.Controls.Add(this.lbl_q1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.lbl_titre);
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.gb_reponses.ResumeLayout(false);
            this.gb_reponses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_q1;
        private System.Windows.Forms.Label lbl_temps;
        private System.Windows.Forms.TextBox txt_temps;
        private System.Windows.Forms.GroupBox gb_reponses;
        private System.Windows.Forms.CheckBox cbox_rep5;
        private System.Windows.Forms.CheckBox cbox_rep4;
        private System.Windows.Forms.CheckBox cbox_rep3;
        private System.Windows.Forms.CheckBox cbox_rep2;
        private System.Windows.Forms.CheckBox cbox_rep1;
    }
}