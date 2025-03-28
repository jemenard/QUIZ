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
using MySqlConnector;
using QUIZ.Model.Controllers;
namespace QUIZ
{
    public partial class Jeu : Form
    {
        int reponseQuestion = 0;
        Partie partie;
        public Timer timer;
        public int timerPartie;
        public int dureeTQuestion;
        public int Difficulte=1;

        public Jeu(string nomJ, string PrenomJ, int difficultePartie)
        {
            Init(nomJ, PrenomJ, difficultePartie);
    }
        private void Init(string nomJ, string PrenomJ, int difficultePartie)
        {
            InitializeComponent();
            progressBar.Maximum = 15;
            progressBar.Value = 0;

            dureeTQuestion = 0;
            DataTable dt = new DataTable();
            ConnectionBDD conn = new ConnectionBDD();
            //Déclaration d'une nouvelle liste
            List<Question> ListeQuestions = new List<Question>();
            //… 
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDQUESTION, ENONCEQUESTION as 'Question', D.IDDIFFICULTE, LABELDIFFICULTE as 'Difficulté',BONREPQUESTION, REPONSE1QUESTION," +
                    " REPONSE2QUESTION, REPONSE3QUESTION, REPONSE4QUESTION, REPONSE5QUESTION FROM QUESTION " +
                    "INNER JOIN DIFFICULTE as D on D.IDDIFFICULTE = QUESTION.IDDIFFICULTE WHERE D.IDDIFFICULTE ="+ difficultePartie + ";", conn.MySqlCo))
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
                ListeQuestions.Add(new Question(row["Question"].ToString(), Convert.ToInt32(row["BONREPQUESTION"]), Convert.ToInt32(row["IDDIFFICULTE"]), row["REPONSE1QUESTION"].ToString()
                    , row["REPONSE2QUESTION"].ToString(), row["REPONSE3QUESTION"].ToString(), row["REPONSE4QUESTION"].ToString(), row["REPONSE5QUESTION"].ToString()));
            }

            partie = new Partie(nomJ, PrenomJ, difficultePartie, ListeQuestions);
            string joueur = PrenomJ + " " + nomJ;
            txt_nomPrenom.Text = joueur;
            txt_difficulte.Text = Convert.ToString(difficultePartie);
            gestionTimer(txt_timer);
            partie.changerQuestion(txt_question, cbox_rep1, cbox_rep2, cbox_rep3, cbox_rep4, cbox_rep5, this, gb_reponses, pb_img, txt_timer, timer, progressBar);

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            partie.validerReponse(reponseQuestion, pb_img);
            partie.nbQuestions++;
            partie.changerQuestion(txt_question, cbox_rep1, cbox_rep2, cbox_rep3, cbox_rep4, cbox_rep5, this, gb_reponses, pb_img, txt_timer, timer, progressBar);
            lbl_question.Text = (partie.nbQuestions + 1).ToString();
            reponseQuestion = 0;
            progressBar.Value = 0;
            dureeTQuestion = 0;
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
        public void gestionTimer(TextBox txt_timer)

        {

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => Timer_Tick(sender, e, txt_timer);
            timer.Start();

        }
        public void Timer_Tick(object sender, EventArgs e, TextBox txt_timer)
        {
            timerPartie++;
            dureeTQuestion++;
            progressBar.Increment(1);
            txt_timer.Text = timerPartie.ToString() + "sec";

            if (dureeTQuestion >= 15)
            {
                progressBar.Value = 0;
                dureeTQuestion = 0;
                partie.validerReponse(reponseQuestion, pb_img);
                partie.nbQuestions++;
                partie.changerQuestion(txt_question, cbox_rep1, cbox_rep2, cbox_rep3, cbox_rep4, cbox_rep5, this, gb_reponses, pb_img, txt_timer, timer, progressBar);
            }
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

