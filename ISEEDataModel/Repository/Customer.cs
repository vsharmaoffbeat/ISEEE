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
    
    public partial class Customer
    {
        public Customer()
        {
            this.CustomerEmployeeContacts = new HashSet<CustomerEmployeeContact>();
            this.CustomerRequests = new HashSet<CustomerRequest>();
            this.GpsEmployeeCustomers = new HashSet<GpsEmployeeCustomer>();
        }
    
        public int CustomerId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int BuildingCode { get; set; }
        public string CustomerNumber { get; set; }
        public int Factory { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Floor { get; set; }
        public string Apartment { get; set; }
        public string AreaPhone1 { get; set; }
        public string Phone1 { get; set; }
        public string AreaPhone2 { get; set; }
        public string Phone2 { get; set; }
        public string AreaCelolar { get; set; }
        public string Celolar { get; set; }
        public string AreaFax { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string CustomerRemark1 { get; set; }
        public string CustomerRemark2 { get; set; }
        public Nullable<int> CustomerStatus { get; set; }
        public Nullable<int> VisitInterval { get; set; }
        public Nullable<System.DateTime> NextVisit { get; set; }
        public Nullable<System.Guid> CustomerKey { get; set; }
        public Nullable<int> VisitDate { get; set; }
        public Nullable<int> VisitTime { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> CustomerActive { get; set; }
        public Nullable<int> CustomerLinkDistance { get; set; }
        public Nullable<int> GisSource { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Long { get; set; }
    
        public virtual Building Building { get; set; }
        public virtual Factory Factory1 { get; set; }
        public virtual ICollection<CustomerEmployeeContact> CustomerEmployeeContacts { get; set; }
        public virtual ICollection<CustomerRequest> CustomerRequests { get; set; }
        public virtual ICollection<GpsEmployeeCustomer> GpsEmployeeCustomers { get; set; }
    }
}