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

namespace WindowsFormsApp1.GSRecption
{
    public partial class recherch : DevExpress.XtraEditors.XtraForm
    {
        GestionMagasinEntities db = new GestionMagasinEntities();
        public recherch()
        {
            InitializeComponent();
        }

       
        
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumCmd.Text);
            var x = (from d in db.Commandes where (d.CodeCommande == num) select d).Count();
            if (x != 0)
            {
                MessageBox.Show("Existe");
                MenuPrincipale.Princ f = new MenuPrincipale.Princ();
                f.OpenForm(new ReceptionCmD(num));
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("NExiste´pas");
            }
        }
    }
}