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
    public partial class Impresion_Transfert : UserControl
    {
        int codeTransfert;
        TextileEntities t = new TextileEntities();
        public Impresion_Transfert()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            List<Contexdb> lst = new List<Contexdb>();
            var p = from tr in t.TblLignesTransferes
                    where tr.CodeTrans == codeTransfert
                    select tr;
            foreach(var tt in p)
            {
                var trr = from tr in t.TblTransferts
                          where tr.CodeTrans == tt.CodeTrans
                          select tr;
                foreach (var tr in trr)
                {
                    var typ = from ty in t.TblTypesTransferts
                              where ty.CodeType == tr.TypeTransfer
                              select ty;
                    foreach (var pp in typ)
                    {
                        lst.Add(new Contexdb
                        {
                            CodeArticle = (string)tt.CodeArticle,
                            CodeTrans = (int)tt.CodeTrans,
                            QuantityNeuve = (int)tt.QuantityNeuve,
                            QuantityReemploi = (int)tt.QuantityReemploi,
                            ValeurTransfert = (float)tt.ValeurTransfert,
                            codeLigne = (int)tt.codeLigne,
                            LibelléType = (string)pp.Libellé,
                            MontantHT = (float)tr.MontantHT,
                            C_Etablissement=(string)tr.C_Etablissement,
                            C_Magasin=(int)tr.C_Magasin,
                            C_PointCons=(int)tr.C_PointCons
                        });
                    }
                }
            }
            TransfertEtat etat = new TransfertEtat();
            etat.SetDataSource(lst);
            crystalReportViewer1.ReportSource=etat;
            crystalReportViewer1.RefreshReport();

        }
    }
}
