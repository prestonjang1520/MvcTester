//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Vet
    {
        public Vet()
        {
            this.Vetclinics = new HashSet<Vetclinic>();
            this.Vetclinics1 = new HashSet<Vetclinic>();
        }
    
        public int VetID { get; set; }
        public Nullable<int> VetClinicID { get; set; }
        public string VetFirstName { get; set; }
        public string VetLastName { get; set; }
        public string VetPhone { get; set; }
        public string VetEmail { get; set; }
    
        public virtual Vetclinic Vetclinic { get; set; }
        public virtual ICollection<Vetclinic> Vetclinics { get; set; }
        public virtual ICollection<Vetclinic> Vetclinics1 { get; set; }
    }
}
