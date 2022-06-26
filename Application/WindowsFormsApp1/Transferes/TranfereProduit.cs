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
    public partial class TranfereProduit : Form
    {
        GestionMagasinEntities db = new GestionMagasinEntities();

        public TranfereProduit()
        {
            InitializeComponent();
        }
        public void Actualise_DetailCommande()
        {
            double v = 0;
            dgvDetailTrans.Rows.Clear();
            foreach (var l in D_Prod.litDetail)
            {
                dgvDetailTrans.Rows.Add(l.id, l.des, l.qteRempy, l.prix, l.total);
            }
            foreach (var p in calc.lst)
            {
                v += p.count;
            }
            txtMontant.Text = v.ToString();
        }
        public void RemplireCombo()
        {
            ComboType.DataSource = db.TypesTransferts.ToList();
            ComboType.DisplayMember = "Libellé";
            ComboType.ValueMember = "CodeType";
            ComboType.SelectedIndex = -1;
        }
        public void RemplireData()
        {
            var b = from v in db.Stocks
                    select v;
            foreach (var z in b)
            {
                dgvProduit.Rows.Add(z.CodeArticle, z.Article.Designation, z.QteActuel, z.Article.Categorie, z.Article.Unite, z.Article.Famile, z.Prix);
            }
           
        }


        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            var lst = db.Stocks.ToList();
            lst = lst.Where(s => s.CodeArticle.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dgvProduit.Rows.Clear();

            foreach (var z in lst)
            {
                dgvProduit.Rows.Add(z.CodeArticle, z.Article.Designation, z.QteActuel, z.Article.Categorie, z.Article.Unite, z.Article.Famile, z.Prix);
            }

        }

        private void dgvProduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TransfProduit f = new TransfProduit(this);
            int v = int.Parse(dgvProduit.CurrentRow.Cells[2].Value.ToString());
            if (v == 0)
            {
                MessageBox.Show("Stock vide", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                f.lblID.Text = dgvProduit.CurrentRow.Cells[0].Value.ToString();
                f.lblDes.Text = dgvProduit.CurrentRow.Cells[1].Value.ToString();
                f.lblPrix.Text = dgvProduit.CurrentRow.Cells[6].Value.ToString();
                f.lblQte.Text = dgvProduit.CurrentRow.Cells[2].Value.ToString();
                f.ShowDialog();
            }

        }

       

        private void TranfereProduit_Load(object sender, EventArgs e)
        {
            Datelbl.Text += " " + DateTime.Now.ToShortDateString();
            RemplireCombo();
            RemplireData();
            var fT = db.Transferts.Select(x => x.CodeTrans).Max();
            if (fT != 0) fT++;
            else fT = 10;
            lblCodeTransfert.Text = fT.ToString();
        }

        

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (ComboType.SelectedIndex != -1 && dgvDetailTrans.Rows.Count != -1 && txtDe.Text != "" && txtA.Text != "")
            {
                //Remplir Transfere
                switch (ComboType.Text)
                {
                    case "TRANSFERT INTER ETABLISSEMENTS":
                        {
                            Transfert transfert = new Transfert();
                            transfert.CodeEtablissement = txtDe.Text;
                            transfert.CodeMagasin = int.Parse(txtA.Text);
                            transfert.MontantHT = float.Parse(txtMontant.Text);
                            transfert.DateTrans = DateTime.Now;
                            transfert.TypeTransfer = int.Parse(ComboType.SelectedValue.ToString());
                            db.Transferts.Add(transfert);
                            db.SaveChanges();
                            break;
                        }

                    case "TRANSFERT MAGASIN POINT DE CONSOMMATION":
                        {
                            Transfert transfert = new Transfert();
                            transfert.CodeMagasin = int.Parse(txtDe.Text);
                            transfert.CodePointCons = int.Parse(txtA.Text);
                            transfert.DateTrans = DateTime.Now;
                            transfert.MontantHT = double.Parse(txtMontant.Text);
                            transfert.TypeTransfer = int.Parse(ComboType.SelectedValue.ToString());
                            db.Transferts.Add(transfert);
                            db.SaveChanges();
                            break;
                        }
                    case "TRANSFERT POINT DE CONSOMMATION VERS MAGASIN":
                        {
                            Transfert transfert = new Transfert();
                            transfert.CodePointCons = int.Parse(txtDe.Text);
                            transfert.CodeMagasin = int.Parse(txtA.Text);
                            transfert.DateTrans = DateTime.Now;
                            transfert.MontantHT = double.Parse(txtMontant.Text);
                            transfert.TypeTransfer = int.Parse(ComboType.SelectedValue.ToString());
                            db.Transferts.Add(transfert);
                            db.SaveChanges();
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

                //Remplir Ligne Transfere
                LignesTransfere lignes = new LignesTransfere();
                lignes.CodeTrans = int.Parse(lblCodeTransfert.Text);

                foreach (DataGridViewRow r in dgvDetailTrans.Rows)
                {
                    lignes.CodeArticle = r.Cells[0].Value.ToString();
                    lignes.QuantitéNeuve = int.Parse(r.Cells[2].Value.ToString());
                    lignes.ValeurTransfert = double.Parse(r.Cells[4].Value.ToString());
                    db.LignesTransferes.Add(lignes);
                    db.SaveChanges();
                }


                ///////
                MessageBox.Show("Felicitation :", "Bien Transferer ..");
                Vider();

            }
            else
            {
                MessageBox.Show("Erreur :", "Probleme de saisie !!!");
            }
        }

        
        public void Vider()
        {
            dgvDetailTrans.Rows.Clear();
            txtA.Text = txtDe.Text = txtMontant.Text = ComboType.Text = "";
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Vider();
        }
    }
}
