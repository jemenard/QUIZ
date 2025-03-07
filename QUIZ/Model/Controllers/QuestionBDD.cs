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
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDQUESTION, ENONCEQUESTION, D.IDDIFFICULTE, LABELDIFFICULTE FROM QUESTION INNER JOIN DIFFICULTE as D on D.IDDIFFICULTE = QUESTION.IDDIFFICULTE;", conn.MySqlCo))
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
    }

}
