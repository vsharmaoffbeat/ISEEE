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
    
    public partial class GpsInputLog_old
    {
        public int SysId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<System.DateTime> SysCreateDate { get; set; }
        public Nullable<int> NextGpsStatus { get; set; }
        public Nullable<int> NextPeriod { get; set; }
        public Nullable<int> Battery { get; set; }
        public Nullable<int> NextSampelRate { get; set; }
        public string InputParametrs { get; set; }
        public string Error { get; set; }
    }
}
