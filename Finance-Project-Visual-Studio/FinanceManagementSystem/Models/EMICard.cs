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
    
    public partial class EMICard
    {
        public EMICard()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public string CardID { get; set; }
        public Nullable<int> RegNumber { get; set; }
        public string CardType { get; set; }
        public int CardLimit { get; set; }
        public System.DateTime ValidityPeriod { get; set; }
        public string AccountStatus { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
