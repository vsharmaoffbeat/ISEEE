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
    
    public partial class RepoetStringLabel
    {
        public RepoetStringLabel()
        {
            this.ReportLocalParmeters = new HashSet<ReportLocalParmeter>();
        }
    
        public int RepoetStringLabelPk { get; set; }
        public string MainString { get; set; }
        public string EN { get; set; }
        public string HE { get; set; }
        public string RU { get; set; }
        public string ES { get; set; }
        public string DE { get; set; }
    
        public virtual ICollection<ReportLocalParmeter> ReportLocalParmeters { get; set; }
    }
}