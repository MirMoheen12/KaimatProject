//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle
    {
        public string strURN { get; set; }
        public string VehicleType { get; set; }
        public string VehicleSubType { get; set; }
        public string MakeModel { get; set; }
        public string RegistrationNo { get; set; }
        public string ChasesNo { get; set; }
        public string Color { get; set; }
        public Nullable<float> size { get; set; }
        public string DeviceLocation { get; set; }
        public string memRemarks { get; set; }
        public Nullable<System.DateTime> dteSent { get; set; }
        public int intID { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
    }
}