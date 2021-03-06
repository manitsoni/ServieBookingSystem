//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblService
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public Nullable<int> VehicalId { get; set; }
        public Nullable<int> MechanicId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string ServiceName { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public Nullable<bool> IsBooked { get; set; }
        public Nullable<bool> IsAssigned { get; set; }
        public Nullable<bool> IsCompleted { get; set; }
        public Nullable<System.DateTime> CompletedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual tblMechanic tblMechanic { get; set; }
        public virtual tblUserRegistration tblUserRegistration { get; set; }
        public virtual tblVehicalDetail tblVehicalDetail { get; set; }
    }
}
