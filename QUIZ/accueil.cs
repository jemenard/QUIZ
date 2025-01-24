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
            if(txt_nom.Text != "" && txt_prenom.Text != "" && cb_difficulte.SelectedIndex != -1)
            {
                Jeu J = new Jeu();
                J.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Merci de ne laisser aucun champs vide", "erreur"
                , MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           
        }

        private void cb_difficulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_difficulte.SelectedItem == "enfer")
            {
                this.BackColor = Color.Red;
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Bold);
            }
            else if(cb_difficulte.SelectedItem == "lunatic")
            {
                this.BackColor = Color.Purple;
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Regular);
            }
        }
    }
}
