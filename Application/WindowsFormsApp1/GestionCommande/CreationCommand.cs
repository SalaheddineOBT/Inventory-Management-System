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
    public partial class CreationCommand : Form
    {
        public CreationCommand()
        {
            InitializeComponent();
        }
        TextileEntities db = new TextileEntities();
        public int i = 0;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            float qte = float.Parse(txtQte.Text); float prix = float.Parse(txtPU.Text);
            i++;
            dataGridView1.Rows.Add(i, txtCodeArt.Text, lblNumCmd.Text, qte, prix, qte * prix);
            int sum = 0;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            txtMT_HT.Text = sum.ToString();
            txtCodeArt.Text = txtPU.Text = txtQte.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            TblCommande c = new TblCommande();
            c.CodeFournisseur = int.Parse(txtFour.Text);
            c.DateCommande = dateTimePicker1.Value;
            c.EtatCommande = "En préparation";
            c.MHT = double.Parse(txtMT_TTC.Text);
            c.Remise = double.Parse(txtRemise.Text);
            c.MontantNet = double.Parse(txtMontant_Net.Text);
            c.TVA = double.Parse(txtTVA.Text);
            c.MTVA = double.Parse(txtMontant_TVA.Text);
            c.PortEmballage = double.Parse(txtPortEmb.Text);
            db.TblCommandes.Add(c);
            db.SaveChanges();

            TblLigneCommande lc = new TblLigneCommande();
            lc.CodeCommande = int.Parse(lblNumCmd.Text);


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                lc.CodeArticle = dataGridView1.Rows[i].Cells[1].Value.ToString();
                lc.Montant = double.Parse(txtMT_HT.Text);
                lc.Prix = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                lc.Qte = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                db.TblLigneCommandes.Add(lc);
                db.SaveChanges();
                MessageBox.Show("Commande en preparation");
                
                db.SaveChanges();
            }
        }
    }
}
