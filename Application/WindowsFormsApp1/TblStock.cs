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
    
    public partial class TblStock
    {
        public Nullable<int> CodeMagasin { get; set; }
        public string codeArticle { get; set; }
        public Nullable<double> Prix { get; set; }
        public Nullable<int> qteEntré { get; set; }
        public Nullable<int> qteSortie { get; set; }
        public Nullable<int> qteActuel { get; set; }
        public Nullable<double> valeurEntre { get; set; }
        public Nullable<double> valeurSortir { get; set; }
        public Nullable<int> RemainingStock { get; set; }
        public Nullable<bool> statu { get; set; }
    
        public virtual TblArticle TblArticle { get; set; }
        public virtual TblMagasin TblMagasin { get; set; }
    }
}