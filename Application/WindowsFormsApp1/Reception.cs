//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reception
    {
        public int NumReception { get; set; }
        public Nullable<int> CodeCommande { get; set; }
        public string CodeArticle { get; set; }
        public Nullable<int> CodeFournisseur { get; set; }
        public System.DateTime DateReception { get; set; }
        public Nullable<int> QTELivree { get; set; }
        public Nullable<int> R_A_L { get; set; }
        public Nullable<double> Montant { get; set; }
    
        public virtual Article Article { get; set; }
        public virtual Commande Commande { get; set; }
        public virtual Fornisseur Fornisseur { get; set; }
    }
}
