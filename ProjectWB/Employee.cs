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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Evidence = new HashSet<Evidence>();
        }
    
        public int Emp_id { get; set; }
        public string Emp_name { get; set; }
        public string Emp_lastname { get; set; }
        public string Emp_username { get; set; }
        public string Emp_password { get; set; }
        public string Emp_position { get; set; }
        public string Emp_Affiliation { get; set; }
        public Nullable<decimal> Emp_balance { get; set; }
        public Nullable<int> rig_no { get; set; }
    
        public virtual RightEmp RightEmp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evidence> Evidence { get; set; }
    }
}
