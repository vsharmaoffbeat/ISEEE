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
    
    public partial class PhoneManufacture
    {
        public PhoneManufacture()
        {
            this.PhoneTypes = new HashSet<PhoneType>();
        }
    
        public int PhoneManufacturId { get; set; }
        public string PhoneManufacture1 { get; set; }
        public Nullable<int> SortingOrder { get; set; }
        public int RecordStatus { get; set; }
    
        public virtual ICollection<PhoneType> PhoneTypes { get; set; }
    }
}