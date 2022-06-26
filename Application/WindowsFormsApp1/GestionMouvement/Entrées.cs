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
    public partial class Entrées : Form
    {
        public Entrées()
        {
            InitializeComponent();
        }
        TextileEntities db = new TextileEntities();
        private void Entrées_Load(object sender, EventArgs e)
        {
            var q = from g in db.TblEntrée select new { g.CodeEntrée, g.DateEntrée, g.QTEEntrée, g.CodeMagasin, g.CodeFournisseur, g.Observation };
            if (q != null)
            {
                dataGridView1.DataSource = q.ToList();
            }
            else { MessageBox.Show("Pas des entrés ds le stock"); }
        }
    }
}
