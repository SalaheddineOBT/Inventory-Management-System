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
    public partial class ReceptionCmD : Form
    {
        GestionMagasinEntities db = new GestionMagasinEntities();
        public ReceptionCmD()
        {
            InitializeComponent();
        }
        public ReceptionCmD(int code)
        {
            InitializeComponent();
            lblNumCmd.Text = code.ToString();
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
           
            
        }

       

        private void ReceptionCmD_Load(object sender, EventArgs e)
        {
            int num = int.Parse(lblNumCmd.Text);
            var z = (from w in db.Commandes where (w.CodeCommande == num) select w).FirstOrDefault();
            
                if (z != null)
                {
                    lblDateCmd.Text = z.DateCommande.ToString();
                    lblCodeFour.Text = z.CodeFournisseur.ToString();
                    lblFourDes.Text = z.Fornisseur.NomComplet;
                    lblRemise.Text = z.Remise.ToString();
                    lblEmballage.Text = z.PortEmballage.ToString();
                    lblTVA.Text = z.TVA.ToString();
                    lblMontat.Text = z.MontantTTC.ToString();
                var p = from c in db.LigneCommandes
                        where c.CodeCommande == z.CodeCommande
                        select c;
                foreach(var n in p)
                {
                    dataGridView1.Rows.Add(n.CodeArticle, n.Article.Designation, n.Qte, n.Prix);
                }
                
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int ql, qc;
            int cd = int.Parse(lblNumCmd.Text);
            Reception r = new Reception();
            r.CodeCommande = int.Parse(lblNumCmd.Text);
            r.CodeFournisseur = int.Parse(lblCodeFour.Text);
            r.DateReception = DateTime.Now;
            


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ql = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                qc = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                r.CodeArticle = (string)dataGridView1.Rows[i].Cells[0].Value;
                r.QTELivree = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                r.Montant = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                r.R_A_L = qc - ql;
                db.Receptions.Add(r);
                db.SaveChanges();

            }
            var p = (from n in db.Commandes
                     where n.CodeCommande == cd
                     select n).FirstOrDefault();
            p.EtatCommande = "Validé";
            db.SaveChanges();



            MessageBox.Show("La commande de numero " + lblNumCmd.Text + " a receptionné");

            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            int qteliv;
            double pu;
            if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), out qteliv)
                && double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), out pu))
            {
                double mt = qteliv * pu;
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = mt.ToString();

            }
        }
    }
}
