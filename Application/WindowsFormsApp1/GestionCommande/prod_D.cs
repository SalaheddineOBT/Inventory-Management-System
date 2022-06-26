using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.GestionCommande
{
    public class prod_D
    {
        public static List<prod_D> litDetail = new List<prod_D>();
        public string id { get; set; }
        public string des { get; set; }

        public string Unité { get; set; }
        public string cat { get; set; }
        public string famille { get; set; }
        public int qte { get; set; }
        public string prix { get; set; }
        public string total { get; set; }

        public double count { get; set; }
    }
}
