using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ.Model
{
    public class Partie
    {
        public string nom;
        public string prenom;
        public int score;
        public int difficulte;
        public int nbQuestionsPartie;
        public List<Question> questions;
        public List<Question> listeAleatoire;
        public int nbReponse;
        public int nbQuestions;

        public Partie(string nom, string prenom, int difficulte, List<Question> ListeQuestions)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.difficulte = difficulte;
            score = 0;
            nbQuestions = 0;
            this.questions = ListeQuestions;
            nbQuestionsPartie = 10;
            listeAleatoireQuestion();
        }

        private void calculerScore(bool bonneReponse)
        {
            if (bonneReponse) score++;
        }

        private void changerImg(PictureBox PbImage, bool bonneReponse, bool raz)
        {
            if (!raz)
            {
                PbImage.Image = bonneReponse ? Properties.Resources.vrai : Properties.Resources.faux;
            }
        }

        private CheckBox getCheckBox(int indice, GroupBox gd_reponse)
        {
            return gd_reponse.Controls.OfType<CheckBox>().FirstOrDefault(c => c.Name == "cbox_rep" + indice);
        }

        private void aleatoireReponse(TextBox txt_affichage, GroupBox gd_reponse)
        {
            Question listeA = listeAleatoire[nbQuestions];
            txt_affichage.Text = listeA.enonce;

            List<int> indices = new List<int> { 1, 2, 3, 4, 5 };
            Random rnd = new Random();
            indices = indices.OrderBy(x => rnd.Next()).ToList();

            for (int i = 0; i < indices.Count; i++)
            {
                int random = indices[i];
                string reponse = listeA.GetProposition(random);
                CheckBox checkBox = getCheckBox(i + 1, gd_reponse);
                if (checkBox != null)
                {
                    checkBox.Text = reponse;
                    checkBox.Tag = (random == listeA.reponse);
                }
                if (random == listeA.reponse)
                {
                    nbReponse = i + 1;
                }
            }
        }

        public void validerReponse(int reponse, PictureBox PbImage)
        {
            bool bonneReponse = (reponse == nbReponse);
            calculerScore(bonneReponse);
            changerImg(PbImage, bonneReponse, false);
        }

        public void changerQuestion(TextBox txt_affichage, CheckBox cbox_rep1, CheckBox cbox_rep2, CheckBox cbox_rep3, CheckBox cbox_rep4, CheckBox cbox_rep5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, TextBox txt_timer, Timer timer, ProgressBar progressBar)
        {
            if (nbQuestions < nbQuestionsPartie)
            {
                aleatoireReponse(txt_affichage, gd_reponse);
                cbox_rep1.Checked = false;
                cbox_rep2.Checked = false;
                cbox_rep3.Checked = false;
                cbox_rep4.Checked = false;
                cbox_rep5.Checked = false;
                progressBar.Value = 0;
            }
            else
            {
                FinDePartie(txt_affichage, cbox_rep1, cbox_rep2, cbox_rep3, cbox_rep4, cbox_rep5, formulaire, gd_reponse, PbImage, txt_timer, timer, progressBar);
            }
        }

        public void FinDePartie(TextBox txt_affichage, CheckBox cbox_rep1, CheckBox cbox_rep2, CheckBox cbox_rep3, CheckBox cbox_rep4, CheckBox cbox_rep5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, TextBox txt_timer, Timer timer, ProgressBar progressBar)
        {
            timer.Stop();
            DialogResult msg;
            msg = MessageBox.Show($"Votre score est de {score}.\nTemps total : {txt_timer.Text}\n\nVoulez-vous rejouer ?",
                    "Fin de la partie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            if (msg == DialogResult.Yes)
            {
                listeAleatoire.Clear();
                listeAleatoireQuestion();               
                score = 0;
                nbQuestions = 0;
                PbImage.Image = Properties.Resources.Interrogation;
                txt_timer.Text = "0 sec";
                timer.Start();
                
                changerQuestion(txt_affichage, cbox_rep1, cbox_rep2, cbox_rep3, cbox_rep4, cbox_rep5, formulaire, gd_reponse, PbImage, txt_timer, timer, progressBar);
            }
            else
            {
                
                accueil Accueil = new accueil();
                Accueil.Show();
                (System.Windows.Forms.Application.OpenForms["Menu"] as menu).openChildForm(Accueil);
                formulaire.Close();
            }
        }
        public void listeAleatoireQuestion()
        {
            listeAleatoire = new List<Question>();
            
            List<int> indices = new List<int>();

            for (int i = 1; i < questions.Count; i++)
            { 
                indices.Add(i);
            }

            Random rnd = new Random();
            

            for (int i = 0; i <= 10; i++)
            {
                int randIndex = rnd.Next(indices.Count);
                int random = indices[randIndex];
                indices.Remove(random);
                
                listeAleatoire.Add(questions[random]);
            }                
            
        }

    }
}
