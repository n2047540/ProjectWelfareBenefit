//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectWB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evidence
    {
        public int Evi_no { get; set; }
        public string Evi_name { get; set; }
        public string Evi_position { get; set; }
        public string Evi_Affiliation { get; set; }
        public string Evi_right { get; set; }
        public string Evi_hospital { get; set; }
        public Nullable<decimal> Evi_ttmoney { get; set; }
        public Nullable<System.DateTime> Evi_date { get; set; }
        public string Evi_approvalstatus { get; set; }
        public Nullable<int> Emp_id { get; set; }
        public Nullable<int> Exe_id { get; set; }
        public Nullable<int> MTS_no { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Executive Executive { get; set; }
        public virtual MoneyTransferStatus MoneyTransferStatus { get; set; }
    }
}
