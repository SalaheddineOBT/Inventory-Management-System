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
    
    public partial class TblArticle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblArticle()
        {
            this.TblLigneCommandes = new HashSet<TblLigneCommande>();
            this.TblLignesTransferes = new HashSet<TblLignesTransfere>();
            this.TblReceptions = new HashSet<TblReception>();
            this.TblSorties = new HashSet<TblSortie>();
        }
    
        public string CodeArticle { get; set; }
        public string Designation { get; set; }
        public string Unite { get; set; }
        public string Famile { get; set; }
        public string CodeCategorie { get; set; }
    
        public virtual TblCategorie TblCategorie { get; set; }
        public virtual TblFamille TblFamille { get; set; }
        public virtual TblUnitéMesures TblUnitéMesures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblLigneCommande> TblLigneCommandes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblLignesTransfere> TblLignesTransferes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblReception> TblReceptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSortie> TblSorties { get; set; }
        public virtual TblStock TblStock { get; set; }
    }
}