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
    
    public partial class Transfert
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transfert()
        {
            this.LignesTransferes = new HashSet<LignesTransfere>();
        }
    
        public int CodeTrans { get; set; }
        public System.DateTime DateTrans { get; set; }
        public Nullable<int> TypeTransfer { get; set; }
        public Nullable<int> CodeMagasin { get; set; }
        public Nullable<int> CodePointCons { get; set; }
        public string CodeEtablissement { get; set; }
        public Nullable<double> MontantHT { get; set; }
    
        public virtual Etablissement Etablissement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LignesTransfere> LignesTransferes { get; set; }
        public virtual Magasin Magasin { get; set; }
        public virtual PointConsommation PointConsommation { get; set; }
        public virtual TypesTransfert TypesTransfert { get; set; }
    }
}
