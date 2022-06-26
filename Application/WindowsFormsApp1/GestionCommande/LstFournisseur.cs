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

namespace WindowsFormsApp1.GestionCommande
{
    public partial class LstFournisseur : DevExpress.XtraEditors.XtraForm
    {
        public LstFournisseur()
        {
            InitializeComponent();
        }
        GestionMagasinEntities db = new GestionMagasinEntities();

        private void LstFournisseur_Load(object sender, EventArgs e)
        {
            foreach(var l in db.Fornisseurs)
            {
                dgvFour.Rows.Add(l.IdFornisseur, l.NomComplet, l.Adress, l.RaisonSocial, l.Tele, l.Email, l.Ville);
            }
        }

        private void dgvFour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFour_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}