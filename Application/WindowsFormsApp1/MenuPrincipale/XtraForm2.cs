using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.MenuPrincipale
{
    public partial class Princ : DevExpress.XtraEditors.XtraForm
    {
        public Princ()
        {
            InitializeComponent();
        }
        private Form A = null;
        public void OpenForm(Form f)
        {
            if (A != null) A.Close();
            A = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            Content.Controls.Add(f);
            Content.Tag = f;
            f.BringToFront();
            f.Show();
        }
        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionCommande.AddCommand());

        }

        private void accordionControlElement24_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_Accueil.Accueil());

        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            GestionCommande.RechercherCommande f = new GestionCommande.RechercherCommande();
            f.ShowDialog();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionMouvement.ListeMouvement());

        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionCommande.Consultation());

        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionMaintenance.Fournisseurs.Consultation_des_Fournissurs());

        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionMaintenance.Categories.Consultation_Categories());

        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionMaintenance.Articles.Gestion_Des_Articles());

        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionMaintenance.Points_de_Consommation.Consoltation_Points_Consommation());

        }

        private void accordionControlElement21_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionMaintenance.Etablissements.Consultation_des_Etablissements());

        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            GSRecption.recherch f = new GSRecption.recherch();
            f.ShowDialog();
        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            OpenForm(new GSRecption.ListerCmdReception());

        }

        private void accordionControlElement18_Click(object sender, EventArgs e)
        {
            OpenForm(new Transferes.TranfereProduit());

        }

        private void accordionControlElement19_Click(object sender, EventArgs e)
        {
            Transferes.Rechercher_Transfet f = new Transferes.Rechercher_Transfet();
            f.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}