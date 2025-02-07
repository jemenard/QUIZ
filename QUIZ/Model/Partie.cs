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
        public int score;
        public int difficulte;
        public int nbQuestionsPartie;
        public List<Question> questions;
        public int nbReponse;
        public int nbQuestions;

        public Partie(List<Question> ListeQuestions)
        {
            score = 0;
            difficulte = 0;
            nbQuestions = 0;
            this.questions = ListeQuestions;
            nbQuestionsPartie = ListeQuestions.Count;
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
            Question question = questions[nbQuestions];
            txt_affichage.Text = question.enonce;

            List<int> indices = new List<int> { 1, 2, 3, 4, 5 };
            Random rnd = new Random();
            indices = indices.OrderBy(x => rnd.Next()).ToList();

            for (int i = 0; i < indices.Count; i++)
            {
                int random = indices[i];
                string reponse = question.GetProposition(random);
                CheckBox checkBox = getCheckBox(i + 1, gd_reponse);
                if (checkBox != null)
                {
                    checkBox.Text = reponse;
                    checkBox.Tag = (random == question.reponse);
                }
                if (random == question.reponse)
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

        public void changerQuestion(TextBox txt_affichage, CheckBox cbox_rep1, CheckBox cbox_rep2, CheckBox cbox_rep3, CheckBox cbox_rep4, CheckBox cbox_rep5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage)
        {
            if (nbQuestions < nbQuestionsPartie)
            {
                aleatoireReponse(txt_affichage, gd_reponse);
                cbox_rep1.Checked = false;
                cbox_rep2.Checked = false;
                cbox_rep3.Checked = false;
                cbox_rep4.Checked = false;
                cbox_rep5.Checked = false;
            }
            else
            {
                FinDePartie(txt_affichage, cbox_rep1, cbox_rep2, cbox_rep3, cbox_rep4, cbox_rep5, formulaire, gd_reponse, PbImage);
            }
        }

        public void FinDePartie(TextBox txt_affichage, CheckBox cbox_rep1, CheckBox cbox_rep2, CheckBox cbox_rep3, CheckBox cbox_rep4, CheckBox cbox_rep5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage)
        {
            DialogResult msg;
            msg = MessageBox.Show("Votre score est de " + score + ".\r\n Voulez vous rejouer", "Fin de la partie"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.Yes)
            {
                score = 0;
                nbQuestions = 0;
                PbImage.Image = Properties.Resources.Interrogation;
                changerQuestion(txt_affichage, cbox_rep1, cbox_rep2, cbox_rep3, cbox_rep4, cbox_rep5, formulaire, gd_reponse, PbImage);
            }
            else
            {
                accueil Accueil = new accueil();
                Accueil.Show();
                formulaire.Hide();
            }
        }
    }
}
