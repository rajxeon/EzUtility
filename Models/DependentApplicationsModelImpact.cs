using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EzUtility.Models
{
    public class DependentApplicationsModelImpact
    {
        public int AppID { get; set; }
        public string ImpactStatment { get; set; }
        public string Stream { get; set; } 
        public int DependentAppID { get; set; }
        public int SID { get; set; }
        public string depApps { get; set; }
 
    }
}


