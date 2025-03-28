using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace QUIZ.Model.Controllers
{
    public class QuestionBDD
    {
        public DataTable GetListeQuestion()
        {
            DataTable dt = new DataTable();
            ConnectionBDD conn = new ConnectionBDD();
            


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

            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            return dt;
        }
        public DataTable GetListeQuestionRecherche(string rechercheMot, int difficulte)
        {
            string rqtSql;
            if (difficulte == 0)
            {
                rqtSql = "SELECT IDQUESTION, ENONCEQUESTION as 'Question', D.IDDIFFICULTE, LABELDIFFICULTE as 'Difficulté' FROM QUESTION " +
                            "INNER JOIN DIFFICULTE as D on D.IDDIFFICULTE = QUESTION.IDDIFFICULTE WHERE ENONCEQUESTION LIKE '%" + @rechercheMot + "%';";
            }
            else
            {
                rqtSql = "SELECT IDQUESTION, ENONCEQUESTION as 'Question', D.IDDIFFICULTE, LABELDIFFICULTE as 'Difficulté' FROM QUESTION " +
                            "INNER JOIN DIFFICULTE as D on D.IDDIFFICULTE = QUESTION.IDDIFFICULTE WHERE ENONCEQUESTION LIKE '%" + @rechercheMot + "%'" +
                            "AND D.IDDIFFICULTE=@difficulte;";
            }
            
            DataTable dt = new DataTable();
            try
            {
                ConnectionBDD conn = new ConnectionBDD();
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    cmd.Parameters.AddWithValue("@rechercheMot", rechercheMot);
                    cmd.Parameters.AddWithValue("@difficulte", difficulte);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dt;

        }
    }

}
