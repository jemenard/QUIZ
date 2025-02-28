using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace QUIZ.Model
{
    public class ConnectionBDD
    {
        private MySqlConnection mySqlCo; //get a faire
        private string serveurBDD;
        private string nomBDD;
        private string loginBDD;
        private string mdpBDD;
        private void initConnexion()
        {
            MySqlCo = new MySqlConnection("Server=" + serveurBDD + ";Database=" + nomBDD + ";User ID=" + loginBDD + ";Password=" + mdpBDD);
        }
        private ConnectionBDD()
        {
            this.serveurBDD = "192.168.10.16";
            this.nomBDD = "BDD_QuizzAndTest";
            this.loginBDD = "menard_jeremy";
            this.mdpBDD = "MqqgSgU4";
            initConnexion();
        }      
    }
}
