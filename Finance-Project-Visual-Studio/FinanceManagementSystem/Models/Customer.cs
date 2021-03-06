//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.EMICards = new HashSet<EMICard>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int RegNumber { get; set; }
        public string CustName { get; set; }
        public int PhoneNo { get; set; }
        public string CustEmail { get; set; }
        public string CustUsername { get; set; }
        public string CustPassword { get; set; }
        public string CustAddress { get; set; }
        public string CardType { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string ApprovalStatus { get; set; }
    
        public virtual ICollection<EMICard> EMICards { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
