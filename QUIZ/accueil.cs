using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ
{
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
            cb_difficulte.Items.Add("facile");
            cb_difficulte.Items.Add("normal");
            cb_difficulte.Items.Add("difficile");
            cb_difficulte.Items.Add("enfer");
            cb_difficulte.Items.Add("lunatic");
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string result = "Bonjour ";
            if (txt_nom.Text == "" || txt_prenom.Text == "")
            {

                MessageBox.Show("Aucun message n'est entré", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_afficher.Text = result;
            }
            else
            {
                result += txt_prenom.Text + " " + txt_nom.Text;
                result+= "\r\n La difficulté sélectionnée est : " + cb_difficulte.SelectedItem; ;
                txt_afficher.Text = result;
            }
           
        }

        private void cb_difficulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_difficulte.SelectedItem == "enfer")
            {
                this.BackColor = Color.Red;
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Bold);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Bold);
            }
            else if(cb_difficulte.SelectedItem == "lunatic")
            {
                this.BackColor = Color.Purple;
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Bold);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Regular);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Regular);
            }
        }
    }
}
