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
    
    public partial class GeocodeToTable
    {
        public int GeocodeToTablePk { get; set; }
        public int CountryCode { get; set; }
        public int AddressTypeTable { get; set; }
        public int GeocodeTagResponse { get; set; }
        public int OrderGeocodeTagResponse { get; set; }
        public int Insert { get; set; }
    
        public virtual AddressTypeTable AddressTypeTable1 { get; set; }
        public virtual Country Country { get; set; }
        public virtual GeocodeStringResponse GeocodeStringResponse { get; set; }
    }
}
