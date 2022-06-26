using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Transferes
{
    public class D_Prod
    {
        public static List<D_Prod> litDetail = new List<D_Prod>();
        public string id { get; set; }
        public string des { get; set; }
        public int qte { get; set; }
        public int qteRempy { get; set; }
        public string prix { get; set; }
        public string total { get; set; }

        //public double count { get; set; }

    }
}
