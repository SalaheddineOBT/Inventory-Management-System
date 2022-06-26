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
    public partial class ListeMouvement : Form
    {
        public ListeMouvement()
        {
            InitializeComponent();
        }
        GestionMagasinEntities db = new GestionMagasinEntities();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var x = (from d in db.Entrée
                     select new
                     {
                         Code = d.CodeEntrée,
                         Article = d.CodeArticle,
                         Fournisseur = d.CodeFournisseur,
                         Date = d.DateEntrée,
                         QteEntrée = d.QteEntrée,
                         PU = d.PU,
                         OBservation = d.Observation
                     }).ToList();
            dataGrid.DataSource = x;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var x = (from d in db.Sorties select new {Code = d.CodeSortie,Article =  d.CodeArticle,PointCons = d.CodePointConsommation,Date = d.DateSortie,QteSortie = d.QTESortie,Observation = d.Observation }).ToList();
            dataGrid.DataSource = x;
        }
    }
}
