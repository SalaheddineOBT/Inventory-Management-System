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
    
    public partial class Entrée
    {
        public int CodeEntrée { get; set; }
        public Nullable<System.DateTime> DateEntrée { get; set; }
        public Nullable<int> QteEntrée { get; set; }
        public Nullable<double> PU { get; set; }
        public Nullable<int> CodeMagasin { get; set; }
        public string CodeArticle { get; set; }
        public Nullable<int> CodeFournisseur { get; set; }
        public string Observation { get; set; }
    
        public virtual Article Article { get; set; }
        public virtual Fornisseur Fornisseur { get; set; }
        public virtual Magasin Magasin { get; set; }
    }
}
