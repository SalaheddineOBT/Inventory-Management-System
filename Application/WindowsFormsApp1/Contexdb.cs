using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Contexdb
    {
        public string LibelléType { get; set; }
        public DateTime DateTrans { get; set; }
        public int TypeTransfer { get; set; }
        public int C_Magasin { get; set; }
        public int C_PointCons { get; set; }
        public string C_Etablissement { get; set; }
        public double MontantHT { get; set; }
        public int codeLigne { get; set; }
        public int CodeTrans { get; set; }
        public string CodeArticle { get; set; }
        public int QuantityNeuve { get; set; }
        public int QuantityReemploi { get; set; }
        public double ValeurTransfert { get; set; }
        public string LibelléMagazin { get; set; }
        public string designationEtablisement { get; set; }
        public string LibelléPoint { get; set; }
    }
}
