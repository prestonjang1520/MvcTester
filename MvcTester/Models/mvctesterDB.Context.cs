﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcTester.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mvctesterEntities1 : DbContext
    {
        public mvctesterEntities1()
            : base("name=mvctesterEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<Petowner> Petowners { get; set; }
        public virtual DbSet<Vet> Vets { get; set; }
        public virtual DbSet<Vetclinic> Vetclinics { get; set; }
    }
}