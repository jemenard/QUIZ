using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUIZ.Model;

namespace QUIZ
{
    public partial class Jeu : Form
    {
        int reponseQuestion = 0;
        Partie partie;


        public Jeu()
        {
            InitializeComponent();
            List<Question> ListeQuestions = new List<Question>
            {
                new Question("Quelle est la capitale de la France ?", 1, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"),
                new Question("Quelle est la capitale de l'Espagne ?", 4, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"),
                new Question("Quelle est la capitale de l'Allemagne ?", 3, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"),
                new Question("Quelle est la capitale de l'Italie ?", 5, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"),
                new Question("Quelle est la capitale de l'Angleterre ?", 2, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome")
            };

            partie = new Partie(ListeQuestions);
            partie.changerQuestion(txt_question, cbox_rep1, cbox_rep2, cbox_rep3, cbox_rep4, cbox_rep5, this, gb_reponses, pb_img);
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            partie.validerReponse(reponseQuestion, pb_img);
            partie.nbQuestions++;
            partie.changerQuestion(txt_question, cbox_rep1, cbox_rep2, cbox_rep3, cbox_rep4, cbox_rep5, this, gb_reponses, pb_img);
            lbl_question.Text = (partie.nbQuestions + 1).ToString();
            reponseQuestion = 0;
        }

        private void check_box_Click(object sender, EventArgs e)
        {
            foreach (var box in gb_reponses.Controls.OfType<CheckBox>())
            {
                box.Checked = false;
            }
            ((CheckBox)sender).Checked = true;

            reponseQuestion = int.Parse(((CheckBox)sender).Name.Replace("cbox_rep", ""));
        }

    }
}

