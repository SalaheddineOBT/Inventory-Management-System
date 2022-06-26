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

namespace WindowsFormsApp1.Transferes
{
    public partial class TransfProduit : DevExpress.XtraEditors.XtraForm
    {
        public Form frmDtl;
        public TransfProduit(Form frm)
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

        private void txtQuantité_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantité.Text != "")
            {

                int qte = int.Parse(txtQuantité.Text);
                int p = int.Parse(lblPrix.Text);
                if (int.Parse(txtQuantité.Text) > int.Parse(lblQte.Text))
                {
                    MessageBox.Show("il y a selement " + int.Parse(lblQte.Text) + "dans le stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantité.Text = "";
                }
                txtTotal.Text = (qte * p).ToString();
            }
           

        }

       

        private void TransfProduit_Load(object sender, EventArgs e)
        {

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
            double p = double.Parse(lblPrix.Text);
            calc c = new calc();
            c.count += q * p;
            calc.lst.Add(c);

            // D_Prod d = new D_Prod();
            //d.count += q*p;
        
            D_Prod d = new D_Prod
            {
                id = lblID.Text,
                des = lblDes.Text,
                qte = int.Parse(lblQte.Text),
                prix = lblPrix.Text,
                qteRempy = q,
                total = txtTotal.Text
            };
            if (D_Prod.litDetail.SingleOrDefault(s => s.id == d.id) != null)
            {
                MessageBox.Show("Produit déja existe dans cammande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                D_Prod.litDetail.Add(d);
            }
            (frmDtl as Transferes.TranfereProduit).Actualise_DetailCommande();
            
            this.Close();
        }
    }
}