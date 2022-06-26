﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GestionMagasinEntities : DbContext
    {
        public GestionMagasinEntities()
            : base("name=GestionMagasinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Authentification> Authentifications { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Entrée> Entrée { get; set; }
        public virtual DbSet<EtabArt> EtabArts { get; set; }
        public virtual DbSet<Etablissement> Etablissements { get; set; }
        public virtual DbSet<Famille> Familles { get; set; }
        public virtual DbSet<Fornisseur> Fornisseurs { get; set; }
        public virtual DbSet<Inventaire> Inventaires { get; set; }
        public virtual DbSet<LigneCommande> LigneCommandes { get; set; }
        public virtual DbSet<LignesTransfere> LignesTransferes { get; set; }
        public virtual DbSet<Magasin> Magasins { get; set; }
        public virtual DbSet<PointConsommation> PointConsommations { get; set; }
        public virtual DbSet<Reception> Receptions { get; set; }
        public virtual DbSet<Sortie> Sorties { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Transfert> Transferts { get; set; }
        public virtual DbSet<TypesTransfert> TypesTransferts { get; set; }
        public virtual DbSet<UnitéMesures> UnitéMesures { get; set; }
    }
}
