using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.GSRecption
{
    public partial class ListerCmdReception : Form
    {
        public ListerCmdReception()
        {
            InitializeComponent();
        }

        private void tablePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        GestionMagasinEntities db = new GestionMagasinEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            /*int Rec = int.Parse(txtNum.Text), Four = int.Parse(txtCodeFour.Text);
            var query = (from w in db.Receptions where (w.NumReception == Rec || w.DateReception == dateTimePicker1.Value || w.CodeFournisseur == Four) select w).First();
            if (!String.IsNullOrEmpty(txtNum.Text))
            {
               
            }

            dataGridView1.DataSource = query;*/
        }

        private void ListerCmdReception_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from z in db.Receptions  select new { z.CodeArticle, z.CodeCommande, z.CodeFournisseur, z.DateReception, z.QTELivree, z.R_A_L, z.Montant }).ToList();

        }
    }
}
