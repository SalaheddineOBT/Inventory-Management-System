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
    public partial class AddCommand : Form
    {
        public AddCommand()
        {
            InitializeComponent();
        }
        GestionMagasinEntities db = new GestionMagasinEntities();
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        public void Actualise_DetailCommande()
        {
            double v = 0;
            dgvDetailCmd.Rows.Clear();
            foreach (var l in prod_D.litDetail)
            {
                dgvDetailCmd.Rows.Add(l.id, l.des,l.qte, l.prix, l.total);
            }
            foreach (var p in prod_D.litDetail)
            {
                v += double.Parse(p.total);
            }
            txtMontant.Text = v.ToString();
        }
        public void remplirDgvProduit()
        {

            var b = from v in db.Stocks select v;
            foreach (var z in b)
            {
                dgvProduit.Rows.Add(z.CodeArticle, z.Article.Designation, z.QteActuel, z.Article.Categorie, z.Article.Unite, z.Article.Famile);
            }
            /*for (int i = 0; i < dgvProduit.Rows.Count; i++)
            {
                if (dgvProduit.Rows[i].Cells[2].Value == null)
                {
                    dgvProduit.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
                if (int.Parse(dgvProduit.Rows[i].Cells[2].Value.ToString() )< 100)
                {
                    dgvProduit.Rows[i].Cells[2].Style.BackColor = Color.Orange;
                }
            }*/
        }
        private void AddCommand_Load(object sender, EventArgs e)
        {
            remplirDgvProduit();
            int c = db.Commandes.Select(x=>x.CodeCommande).Max();
            c++;
            lblNumCmd.Text = c.ToString();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var lst = db.Articles.ToList();
            lst = lst.Where(s => s.CodeArticle.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dgvProduit.Rows.Clear();

            foreach(var z in lst)
            {
                dgvProduit.Rows.Add(z.CodeArticle, z.Designation, z.Stock.QteActuel, z.Categorie, z.Unite, z.Famile);
            }

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LstFournisseur l = new LstFournisseur();
            l.ShowDialog();
            txtFour.Text=l.dgvFour.CurrentRow.Cells[0].Value.ToString();
            txtNom.Text = l.dgvFour.CurrentRow.Cells[1].Value.ToString();
            txtRS.Text = l.dgvFour.CurrentRow.Cells[3].Value.ToString();
            txtAdrs.Text = l.dgvFour.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = l.dgvFour.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = l.dgvFour.CurrentRow.Cells[5].Value.ToString();
        }


        private void dgvProduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CommandeProduit f = new CommandeProduit(this);
            int v = int.Parse(dgvProduit.CurrentRow.Cells[2].Value.ToString());
            if (v == 0)
            {
                MessageBox.Show("Stock vide", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                f.lblID.Text = dgvProduit.CurrentRow.Cells[0].Value.ToString();
                f.lblDes.Text = dgvProduit.CurrentRow.Cells[1].Value.ToString();
                f.lblCatégorie.Text = dgvProduit.CurrentRow.Cells[3].Value.ToString();
                f.lblUnité.Text = dgvProduit.CurrentRow.Cells[4].Value.ToString();
                f.lblFamille.Text= dgvProduit.CurrentRow.Cells[5].Value.ToString();
                f.ShowDialog();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Commande c = new Commande();
            c.CodeFournisseur = int.Parse(txtFour.Text);
            c.DateCommande = dateTimePicker1.Value;
            c.EtatCommande = "En Préparation";
            c.MontantTTC = double.Parse(txtMT_TTC.Text);
            c.Remise = double.Parse(txtRemise.Text);
            c.MontantNet = double.Parse(txtMontant_Net.Text);
            c.TVA = double.Parse(txtTVA.Text);
            c.MTVA = double.Parse(txtMontant_TVA.Text);
            c.MontantHT = double.Parse(txtMontant.Text);
            c.PortEmballage = double.Parse(txtPortEmb.Text);
            db.Commandes.Add(c);
            db.SaveChanges();

            LigneCommande lc = new LigneCommande();
            lc.CodeCommande = int.Parse(lblNumCmd.Text);


            for (int i = 0; i < dgvDetailCmd.Rows.Count; i++)
            {

                lc.CodeArticle = dgvDetailCmd.Rows[i].Cells[0].Value.ToString();
                lc.MontantHT = double.Parse(txtMontant.Text);
                lc.Prix = double.Parse(dgvDetailCmd.Rows[i].Cells[4].Value.ToString());
                lc.Qte = int.Parse(dgvDetailCmd.Rows[i].Cells[3].Value.ToString());
                db.LigneCommandes.Add(lc);
                db.SaveChanges();
            }
            MessageBox.Show("Commande en preparation");
            vider(); 
            int cc = db.Commandes.Select(x => x.CodeCommande).Max();
            cc++;
            lblNumCmd.Text = cc.ToString();
            int z = (from d in db.Commandes select d.CodeCommande).Max() + 1;
            lblNumCmd.Text = z.ToString();
        }
        

        private void txtRemise_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float remise = float.Parse(txtRemise.Text) / 100;
                txtMontant_Net.Text = (float.Parse(txtMontant.Text) * remise).ToString();
                txtPortEmb.Focus();
            }
        }

        private void txtPortEmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTVA.Focus();
            }
        }

        private void txtTVA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float remise = float.Parse(txtTVA.Text) / 100;
                txtMontant_TVA.Text = ((float.Parse(txtMontant_Net.Text) * remise) + (float.Parse(txtPortEmb.Text) * remise)).ToString();
                txtMT_TTC.Text = (float.Parse(txtMontant_Net.Text) + float.Parse(txtPortEmb.Text) + float.Parse(txtMontant_TVA.Text)).ToString();
            }
        }

        public void vider()
        {
            dateTimePicker1.Value = DateTime.Now;
            txtNom.Text  =txtMontant_Net.Text=txtEmail.Text=txtAdrs.Text=txtMontant_TVA.Text=txtMontant_Net.Text=txtMT_TTC.Text=txtPortEmb.Text=txtRemise.Text="";
            txtTel.Text = txtTVA.Text = txtRS.Text = "";
            dgvDetailCmd.Rows.Clear();
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
