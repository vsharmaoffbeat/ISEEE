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
    
    public partial class EmployeeGpsLog
    {
        public int GpsSysId { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime GpsDate { get; set; }
        public System.TimeSpan GpsTime { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Long { get; set; }
        public Nullable<double> Accuracy { get; set; }
        public Nullable<int> AvgDistance { get; set; }
        public Nullable<int> IsStanding { get; set; }
        public Nullable<int> Satellite { get; set; }
        public Nullable<int> ProcessStatus { get; set; }
        public Nullable<System.DateTime> CreateUtc { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}