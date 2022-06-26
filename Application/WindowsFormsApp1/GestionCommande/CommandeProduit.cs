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
    public partial class CommandeProduit : DevExpress.XtraEditors.XtraForm
    {
        public CommandeProduit()
        {
            InitializeComponent();
        }
        public Form frmDtl;

        public CommandeProduit(Form frm)
        {
            InitializeComponent();
            frmDtl = frm;
        }
        private void txtQuantité_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int q;
            if (txtQuantité.Text != "")
            {
                q = int.Parse(txtQuantité.Text);
            }
            else
            {
                q = 1;
            }
            double v = double.Parse(txtPU.Text);
            prod_D c = new prod_D();

            //calc.lst.Add(c);
            prod_D d = new prod_D
            {
                id = lblID.Text,
                des = lblDes.Text,
                qte = int.Parse(txtQuantité.Text),
                prix = txtPU.Text,
                total = txtTotal.Text
            };
            if (prod_D.litDetail.SingleOrDefault(s => s.id == d.id) != null)
            {
                MessageBox.Show("Produit déja existe dans cammande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                prod_D.litDetail.Add(d);
            }
            (frmDtl as AddCommand).Actualise_DetailCommande();

            this.Close();
        }

        private void txtPU_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantité.Text != "")
            {

                int qte = int.Parse(txtQuantité.Text);
                int p = int.Parse(txtPU.Text);

                txtTotal.Text = (qte * p).ToString();
            }
        }

    }
}