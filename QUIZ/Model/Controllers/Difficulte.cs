using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace QUIZ.Model.Controllers
{
    public class Difficulte
    {
        public DataTable GetListeDifficulte()
        {
            DataTable dt_ListeDifficulte = new DataTable();
            ConnectionBDD conn = new ConnectionBDD();



            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDDIFFICULTE,LABELDIFFICULTE FROM DIFFICULTE;", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt_ListeDifficulte.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            DataRow workRow = dt_ListeDifficulte.NewRow();
            workRow[0] = -1;
            workRow[1] = "";
            dt_ListeDifficulte.Rows.InsertAt(workRow, 0);
            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            return dt_ListeDifficulte;
        }
    }
}
