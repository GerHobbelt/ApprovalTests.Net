//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApprovalTests.MachineSpecific.Tests.NHibernate
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public int Id { get; set; }
        public Nullable<int> Employee { get; set; }
        public string EventTitle { get; set; }
        public string Details { get; set; }
    
        public virtual Employee Employee1 { get; set; }
    }
}
