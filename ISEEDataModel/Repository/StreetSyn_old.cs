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
    
    public partial class StreetSyn_old
    {
        public int SysId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StatusCode { get; set; }
        public int CountryCode { get; set; }
        public Nullable<int> StateCode { get; set; }
        public int CityCode { get; set; }
        public int StreetCode { get; set; }
        public string StreetDesc { get; set; }
    
        public virtual Street Street { get; set; }
    }
}