using System;
using System.Collections.Generic;
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

        private void calculerScore(bool reponse)
        {
            score++;
        }
        private void changerImg(PictureBox PbImage, bool BonneReponse, bool raz)
        {
            if (!raz)
            {
                if (BonneReponse)
                {
                    PbImage.Image = Properties.Resources.vrai;
                }
                else
                {
                    PbImage.Image = Properties.Resources.faux;
                }
            }
        }

        private CheckBox getCheckBox(int indice, GroupBox gd_reponse)
        {
            foreach (Control c in gd_reponse.Controls)
            {
                if (c.GetType() == typeof(CheckBox) && c.Name == "ckb_reponse" + indice.ToString())
                {
                    return ((CheckBox)c);
                }
            }
            return null;
        }

        private void aleatoireReponse(TextBox txt_affichage, GroupBox gd_reponse)
        {
            int bonneReponse = questions[nbQuestions].reponse;
            txt_affichage.Text = questions[nbQuestions].enonce;
            List<int> reponseAleatoire = new List<int>() { 1, 2, 3, 4, 5 };
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int randIndex = rnd.Next(reponseAleatoire.Count);
                int random = reponseAleatoire[randIndex];
                reponseAleatoire.Remove(random);
                string reponse = "";

                //Réaliser un switch permettant d’affecter à
                //reponse la proposition sélectionnée de manière aléatoire
                switch(getCheckBox(i,gb_reponses))
                {
                    case 1:
                        reponse= questions[nbQuestions].proposition1;
                    break;
                    case 2:
                        reponse = questions[nbQuestions].proposition2;
                        break;
                    case 3:
                        reponse = questions[nbQuestions].proposition3;
                        break;
                    case 4:
                        reponse = questions[nbQuestions].proposition4;
                        break;
                    case 5:
                        reponse = questions[nbQuestions].proposition5;
                        break;
                }
                getCheckBox(i, gd_reponse).Text = reponse;
                if (bonneReponse == random)
                {
                    nbReponse = i;
                }
            }
        }

        public void validerReponse(int reponse, PictureBox PbImage)
        {
            if (reponse == nbReponse)
            {
                calculerScore(true);
                changerImg(PbImage, true, false);
            }
            else
            {
                calculerScore(false);
                changerImg(PbImage, false, false);
            }
        }

        public void changerQuestion(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage)
        {
            if (// On teste si il reste des questions )
            { 
                aleatoireReponse(txt_affichage, gd_reponse);
                // On décoche les 5 checkbox

            }
            else
            {
                //appel de la méthode de fin de partie qui sera réalisé plus tard
            }
        }

    }

}
