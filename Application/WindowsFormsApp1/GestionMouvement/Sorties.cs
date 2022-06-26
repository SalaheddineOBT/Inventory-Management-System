using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.GestionMouvement
{
    public partial class Sorties : Form
    {
        public Sorties()
        {
            InitializeComponent();
        }
        TextileEntities db = new TextileEntities();
        private void Sorties_Load(object sender, EventArgs e)
        {
            var q = from z in db.TblSorties select new { z.CodeSortie, z.DateSortie, z.CodeArticle, z.CodeMagasin, z.CodePointConsommation, z.QTESortie, z.Observation };
            if (q != null)
            {
                dataGridView1.DataSource = q.ToList();
            }
            else { MessageBox.Show("Pas de Sorties"); }
        }
    }
}
