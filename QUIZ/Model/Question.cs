using QUIZ.Model.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace QUIZ.Model
{
    public class Question
    {
        public string enonce;
        public int reponse;
        public int difficulte;
        private string[] propositions;

        public Question(string enonce, int reponse, int difficulte, string prop1, string prop2, string prop3, string prop4, string prop5)
        {
            this.enonce = enonce;
            this.reponse = reponse;
            this.difficulte = difficulte;
            this.propositions = new string[] { prop1, prop2, prop3, prop4, prop5 };
        }

        public string GetProposition(int index)
        {
            return (index >= 1 && index <= 5) ? propositions[index - 1] : "";
        }
        public Question(int difficulte)
        {
            DataTable dt = new DataTable();
            ConnectionBDD conn = new ConnectionBDD();
            //Déclaration d'une nouvelle liste
            List<Question> ListeQuestions = new List<Question>();
            //… 
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDQUESTION, ENONCEQUESTION as 'Question', D.IDDIFFICULTE, LABELDIFFICULTE as 'Difficulté' FROM QUESTION INNER JOIN DIFFICULTE as D on D.IDDIFFICULTE = QUESTION.IDDIFFICULTE;", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            //Remplir une liste avec une datatable
            foreach (DataRow row in dt.Rows)
            {
                ListeQuestions.Add(new Question(row["ENONCEQUESTION"].ToString(), row["BONREPONSEQUESTION"].ToString());
            }

        }
    }
}
