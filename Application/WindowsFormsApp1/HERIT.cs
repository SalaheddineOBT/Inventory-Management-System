using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class HERIT
    {
        public string CodeArticle { get; set; }
        public string Designation_Article{ get; set; }

        public string CODE_Cat { get; set; }
        public string LIBELLE_Cat { get; set; }


        public int CodeCommande { get; set; }
        public int CodeFournisseur { get; set; }
        public DateTime DateCommande { get; set; }
        public DateTime dateLivraison { get; set; }
        public string EtatCommande { get; set; }
        public double MontantTTC { get; set; }
        public double Remise { get; set; }
        public double MontantNet { get; set; }
        public double TVA { get; set; }
        public double PortEmballage { get; set; }
        public double MTVA { get; set; }

        public int CodeEntrée { get; set; }
        public DateTime DateEntrée { get; set; }
        public int QteEntrée { get; set; }
        public double PU { get; set; }
        public int CodeMagasin { get; set; }
        public string Observation { get; set; }
        public string CodeEtab { get; set; }
        public string Designation{ get; set; }
        public string Adresse_ETAB { get; set; }
        public string TEL{ get; set; }
        public string Ville { get; set; }

        public string CodeFamile { get; set; }
        public string NomComplet { get; set; }
        public string Adress { get; set; }
        public string RaisonSocial { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        public int CodeLign { get; set; }


        public int NumCons { get; set; }
        public string Enseignant { get; set; }

        public int CodeSortie { get; set; }
        public DateTime DateSortie { get; set; }
        public int QTESortie { get; set; }

        public double QteActuel { get; set; }
        public double ValeurEntré { get; set; }
        public double ValeurSortie { get; set; }
        public double RemainingStock { get; set; }
        public bool Statut { get; set; }
        public int CodeTrans { get; set; }
        public DateTime DateTrans { get; set; }
        public int TypeTransfer { get; set; }
        public int CodeType { get; set; }
        public string CodeUnite { get; set; }
        public string NomV { get; set; }

    }
}
