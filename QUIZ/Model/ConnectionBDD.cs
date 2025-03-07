using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using MySqlConnector;

namespace QUIZ.Model
{
    public class ConnectionBDD
    {
        private MySqlConnection mySqlCo;
        public MySqlConnection MySqlCo
        {
            get { return mySqlCo; }
            set { mySqlCo = value; }
        }//get a faire
        private string serveurBDD;
        private string nomBDD;
        private string loginBDD;
        private string mdpBDD;
        
        
        
        private void initConnexion()
        {
            mySqlCo = new MySqlConnection("Server=" + serveurBDD + ";Database=" + nomBDD + ";User ID=" + loginBDD + ";Password=" + mdpBDD);
        }
        public ConnectionBDD()
        {
            this.serveurBDD = "192.168.10.16";
            this.nomBDD = "menard_jeremy_BDD_QuizzAndTest";
            this.loginBDD = "menard_jeremy";
            this.mdpBDD = "MqqgSgU4";
            initConnexion();
        }      
    }
}
