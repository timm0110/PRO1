//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlanDijak
    {
        public int PlaID { get; set; }
        public int DijID { get; set; }
        public string BrezVeze { get; set; }
    
        public virtual Dijak Dijak { get; set; }
        public virtual PlanDejavnosti PlanDejavnosti { get; set; }
    }
}
