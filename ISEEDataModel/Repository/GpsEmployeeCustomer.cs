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
    
    public partial class GpsEmployeeCustomer
    {
        public int SysId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime VisiteDate { get; set; }
        public System.TimeSpan VisitTime { get; set; }
        public Nullable<int> GpsPointId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int InsertStatus { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual EmployeeGpsPoint EmployeeGpsPoint { get; set; }
        public virtual Employee Employee { get; set; }
    }
}