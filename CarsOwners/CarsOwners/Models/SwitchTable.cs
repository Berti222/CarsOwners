//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarsOwners.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SwitchTable
    {
        public int Id { get; set; }
        public Nullable<int> OwnersId { get; set; }
        public Nullable<int> CarsId { get; set; }
    
        public virtual Cars Cars { get; set; }
        public virtual Owners Owners { get; set; }
    }
}
