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
    
    public partial class CommonLink
    {
        public string strURN { get; set; }
        public string strURNDest { get; set; }
        public string strURNSource { get; set; }
        public string strLink { get; set; }
        public int intID { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> InformationEvaluation { get; set; }
        public Nullable<int> SourceEvaluation { get; set; }
        public int intDbIdDest { get; set; }
        public int intDbIdSource { get; set; }
        public Nullable<bool> optBiDirectional { get; set; }
        public string textSearch { get; set; }
    }
}