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
    
    public partial class RequsetToFactoryLevel2
    {
        public RequsetToFactoryLevel2()
        {
            this.CustomerRequests = new HashSet<CustomerRequest>();
        }
    
        public int RequestSysIdLevel2 { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int RequestSysIdLevel1 { get; set; }
        public int RequestIdLevel2 { get; set; }
        public string RequestDescCodeLevel2 { get; set; }
        public Nullable<int> RequsetOrder { get; set; }
        public Nullable<int> StatusCode { get; set; }
    
        public virtual ICollection<CustomerRequest> CustomerRequests { get; set; }
        public virtual RequsetToFactoryLevel1 RequsetToFactoryLevel1 { get; set; }
    }
}
