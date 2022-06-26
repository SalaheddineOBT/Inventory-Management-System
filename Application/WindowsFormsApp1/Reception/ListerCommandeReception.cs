using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Reception
{
    public partial class ListerCommandeReception : Form
    {
        public ListerCommandeReception()
        {
            InitializeComponent();
        }
        TextileEntities db = new TextileEntities();
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int Rec = int.Parse(txtNum.Text), Four = int.Parse(txtCodeFour.Text);

            var query = (from w in db.TblReceptions where (w.numReception == Rec || w.DateReception == dateTimePicker1.Value || w.CodeFournisseur == Four) select w).SingleOrDefault();
            dataGridView1.DataSource = query;
        }

        private void ListerCommandeReception_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from z in db.TblReceptions select new { z.CodeArticle, z.CodeCommande, z.CodeFournisseur, z.DateReception, z.QTELivree, z.R_A_L, z.Montant }).ToList();
        }
    }
}
