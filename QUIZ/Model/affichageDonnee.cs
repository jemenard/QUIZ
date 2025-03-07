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
            dgv_questions.Columns["ENONCEQUESTION"].Width = 190;
            //Attention il faut mettre le nom des alias à la place du nom des colonnes en cas d’utilisation d’alias dans la requête SQL.
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
