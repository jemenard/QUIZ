using QUIZ.Model.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ.Model
{
    public partial class affichageDonnee : Form
    {
        DataView dv;
        public affichageDonnee()
        {
            InitializeComponent();
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestion());
            dgv_questions.DataSource = dv;
            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            dgv_questions.Columns["IDQUESTION"].Visible = false;
            dgv_questions.Columns["IDDIFFICULTE"].Visible = false;
            //Gérer la largeur des colonnes
            dgv_questions.Columns["Question"].Width = 190;
            dgv_questions.Columns["Difficulté"].Width = 190;
            //Attention il faut mettre le nom des alias à la place du nom des colonnes en cas d’utilisation d’alias dans la requête SQL.  
            Difficulte dt_ListeDifficulte = new Difficulte();
            cb_difficulte.DataSource = dt_ListeDifficulte.GetListeDifficulte();
            cb_difficulte.DisplayMember = "LABELDIFFICULTE"; //nom de l’alias SQL ou nom de la colonne
            cb_difficulte.ValueMember = "IDDIFFICULTE";  //nom de l’alias SQL ou nom de la colonne
            

        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_rechercheM_TextChanged(object sender, EventArgs e)
        {
            DataView dv;
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestionRecherche(txt_rechercheM.Text, cb_difficulte.SelectedIndex));
            dgv_questions.DataSource = dv;
        }

        private void cb_difficulte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv;
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestionRecherche(txt_rechercheM.Text, cb_difficulte.SelectedIndex));
            dgv_questions.DataSource = dv;
        }
    }
}
