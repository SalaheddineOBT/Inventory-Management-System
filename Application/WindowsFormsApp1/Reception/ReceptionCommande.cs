using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Reception
{
    public partial class ReceptionCommande : Form
    {
        public ReceptionCommande()
        {
            InitializeComponent();
        }
        TextileEntities db = new TextileEntities();
        private void txtNumCmd_KeyDown(object sender, KeyEventArgs e)
        {
            int num = int.Parse(txtNumCmd.Text);
            var z = (from w in db.TblCommandes where (w.CodeCommande == num && w.EtatCommande == "En prépartion") select w).FirstOrDefault();
            if (e.KeyCode == Keys.Enter)
            {
                if (z != null)
                {
                    lblDateCmd.Text = z.DateCommande.ToString();
                    lblCodeFour.Text = z.CodeFournisseur.ToString();
                    lblFourDes.Text = z.TblFornisseur.Nom;
                    lblRemise.Text = z.Remise.ToString();
                    lblEmballage.Text = z.PortEmballage.ToString();
                    lblTVA.Text = z.TVA.ToString();
                    lblMontat.Text = z.MHT.ToString();

                    dataGridView1.DataSource = (from v in db.TblLigneCommandes
                                                where (v.CodeCommande == num)
                                                select new
                                                {
                                                    Article = v.CodeArticle,
                                                    Designation = v.TblArticle.Designation,
                                                    qteCommand = v.Qte,
                                                    PU = v.Prix
                                                }).ToList();
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int qteliv;
            double pu;
            if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["QteLiv"].Value.ToString(), out qteliv)
                && double.TryParse(dataGridView1.Rows[e.RowIndex].Cells["PU"].Value.ToString(), out pu))
            {
                double mt = qteliv * pu;
                dataGridView1.Rows[e.RowIndex].Cells["MT"].Value = mt.ToString();

            }
        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TblReception r = new TblReception();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                r.CodeArticle = (string)dataGridView1.Rows[i].Cells[1].Value;
                r.QTELivree = (int)dataGridView1.Rows[i].Cells[4].Value;
                r.Montant = (double)dataGridView1.Rows[i].Cells[6].Value;
                r.R_A_L = (int)dataGridView1.Rows[i].Cells[3].Value - (int)dataGridView1.Rows[i].Cells[4].Value;

            }
            r.CodeCommande = int.Parse(txtNumCmd.Text);
            r.CodeFournisseur = int.Parse(lblCodeFour.Text);
            //r.DateReception = ;


            db.TblReceptions.Add(r);
            db.SaveChanges();

            MessageBox.Show("La commande de numero " + txtNumCmd.Text + " a receptionné");

            dataGridView1.Rows.Clear();
            txtNumCmd.Text = "";
        }
    }
}
