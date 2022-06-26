using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Connexion
{
    public partial class FrmCnx : Form
    {
        GestionMagasinEntities db = new GestionMagasinEntities();
        public FrmCnx()
        {
            InitializeComponent();
        }
        string  test() {
            if ( txtUser.Text== "User" || txtUser.Text=="")
            {
                return "Entrer votre user";
            }
            if(txtMotPass.Text ==""||txtMotPass.Text == "Mot de Pass")
            {
                return "Entrer votre Mot de Pass";
            }
            return null;
                }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "User")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtMotPass_Enter(object sender, EventArgs e)
        {
            if (txtMotPass.Text == "Mot de Pass")
            {
                txtMotPass.Text = "";
                txtMotPass.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "User";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtMotPass_Leave(object sender, EventArgs e)
        {
            if (txtMotPass.Text == "")
            {
                txtMotPass.Text = "Mot de Pass";
               txtMotPass.ForeColor = Color.Silver;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            /*if (test() == null)
            {
                var x = (from v in db.Authentifications where (v.Email == txtUser.Text && v.Password == txtMotPass.Text) select v).SingleOrDefault();
                if (x != null)
                {
                    MessageBox.Show("Connexion a réussi", "Coonnexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {

                    MessageBox.Show("Connexion a échoué", "Coonnexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(test(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            MenuPrincipale.Princ f = new MenuPrincipale.Princ();
            f.Show();
        }
    }
}
