using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUIZ.Model;

namespace QUIZ
{
    public class SousFormulaire

    {
        public Panel PanelSousFormlaire;
        public Form activeForm = null;
        public SousFormulaire(Panel pnl_SF)
        {
            PanelSousFormlaire = pnl_SF;
            SousFormulaire SF = new SousFormulaire(pnl_SF);
            SF.openChildForm(new accueil());
        }
        public void openChildForm(Form formEnfant)

        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            PanelSousFormlaire.Controls.Add(formEnfant);
            PanelSousFormlaire.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }







    }
}
