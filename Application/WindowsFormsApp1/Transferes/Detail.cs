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
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }
        int nb = 0;
        int codeT;
        GestionMagasinEntities db = new GestionMagasinEntities();
        public Detail(int code)
        {
            InitializeComponent();
            this.codeT= code;
        }
        public void remplirDgv()
        {
            var l = from c in db.LignesTransferes where (c.CodeTrans == codeT) select c;
            foreach(var p in l)
            {
                gridTransfert.Rows.Add(p.CodeArticle, p.Article.Designation, p.QuantitéNeuve, p.QuantitéRemploi);
            }

        }

        public void Affiche()
        {
            var transfert = (from v in db.Transferts
                    where v.CodeTrans == codeT
                    select v).FirstOrDefault();
            if (transfert != null)
            {
                CodeTrans.Text += "  " + transfert.CodeTrans;
                label6.Text = transfert.DateTrans.ToShortDateString();

                TypesTransfert types = db.TypesTransferts.Where(x => x.CodeType == transfert.TypeTransfer).FirstOrDefault();
                if (types != null)
                {
                    lblType.Text = types.Libellé;
                    switch (lblType.Text)
                    {
                        case "TRANSFERT MAGASIN POINT DE CONSOMMATION":
                            {
                                Originelbl.Text += "  " + transfert.CodeMagasin;
                                Magasin magasin = db.Magasins.Where(x => x.CodeMagasin == transfert.CodeMagasin).FirstOrDefault();
                                Originelbl.Text += "  " + magasin.Libellé;

                                benlbl.Text += "  " + transfert.CodePointCons;
                                PointConsommation point = db.PointConsommations.Where(x => x.NumCons == transfert.CodePointCons).FirstOrDefault();
                                benlbl.Text += "  " + point.Libellé;

                                break;
                            }
                        case "TRANSFERT POINT DE CONSOMMATION VERS MAGASIN":
                            {
                                benlbl.Text += "  " + transfert.CodeMagasin;
                                Magasin magasin = db.Magasins.Where(x => x.CodeMagasin == transfert.CodeMagasin).FirstOrDefault();
                                benlbl.Text += "  " + magasin.Libellé;

                                Originelbl.Text += "  " + transfert.CodePointCons;
                                PointConsommation point = db.PointConsommations.Where(x => x.NumCons == transfert.CodePointCons).FirstOrDefault();
                                Originelbl.Text += "  " + point.Libellé;

                                break;
                            }
                        case "TRANSFERT INTER ETABLISSEMENTS":
                            {
                                benlbl.Text += "  " + transfert.CodeEtablissement;
                                Etablissement etab = db.Etablissements.Where(x => x.CodeEtab == transfert.CodeEtablissement).FirstOrDefault();
                                benlbl.Text += "  " + etab.Designation;

                                Originelbl.Text += "  " + transfert.CodeMagasin;
                                Magasin magasin = db.Magasins.Where(x => x.CodeMagasin == transfert.CodeMagasin).FirstOrDefault();
                                Originelbl.Text += "  " + magasin.Libellé;

                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }

            }

        }

        private void Detail_Load(object sender, EventArgs e)
        {
            remplirDgv(); Affiche();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
