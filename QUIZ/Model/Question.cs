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
           
        }
    }
}
