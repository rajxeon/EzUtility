//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EzUtility
{
    using System;
    using System.Collections.Generic;
    
    public partial class DependencyMatrix
    {
        public int SID { get; set; }
        public int AppID { get; set; }
        public int DependentAppID { get; set; }
        public string Stream { get; set; }
        public string ImpactStatment { get; set; }
        public string DependentApp { get; set; }
    
        public virtual Application_Base Application_Base { get; set; }
        public virtual Application_Base Application_Base1 { get; set; }
    }
}
