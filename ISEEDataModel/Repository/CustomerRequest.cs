//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISEEDataModel.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerRequest
    {
        public int SysId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CustomerId { get; set; }
        public int RequestSysIdLevel2 { get; set; }
        public string Request { get; set; }
        public string Treatment { get; set; }
        public Nullable<System.DateTime> TreatmentDate { get; set; }
        public int Status { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual RequsetToFactoryLevel2 RequsetToFactoryLevel2 { get; set; }
    }
}
