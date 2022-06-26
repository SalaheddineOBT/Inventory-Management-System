using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Consommation : Form
    {
        public Consommation()
        {
            InitializeComponent();
        }
        GestionMagasinEntities db = new GestionMagasinEntities();
        private void btnrecherche_Click(object sender, EventArgs e)
        {
            var c = from z in db.EtabArts
                    join v in db.Sorties on z.codeArt equals v.CodeArticle
                    where (v.DateSortie >= dateDeb.Value && v.DateSortie <= dateFin.Value && z.codeEtab == txtCode.Text)
                    select z;
            if(c != null)
            {
                foreach(var z in c)
                {
                  //  var w = from x in db.Sorties where (x.CodeArticle == z.codeArt) select new {x.CodeArticle ,x.Article.Designation,x.
                    
                }
            }
        }
    }
}
