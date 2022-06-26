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
    
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            this.LigneCommandes = new HashSet<LigneCommande>();
            this.Receptions = new HashSet<Reception>();
        }
    
        public int CodeCommande { get; set; }
        public Nullable<int> CodeFournisseur { get; set; }
        public System.DateTime DateCommande { get; set; }
        public Nullable<System.DateTime> dateLivraison { get; set; }
        public string EtatCommande { get; set; }
        public Nullable<double> MontantTTC { get; set; }
        public Nullable<double> Remise { get; set; }
        public Nullable<double> MontantNet { get; set; }
        public Nullable<double> TVA { get; set; }
        public Nullable<double> PortEmballage { get; set; }
        public Nullable<double> MTVA { get; set; }
        public Nullable<double> MontantHT { get; set; }
    
        public virtual Fornisseur Fornisseur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LigneCommande> LigneCommandes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reception> Receptions { get; set; }
    }
}
