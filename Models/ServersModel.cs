using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EzUtility.Models
{
    public class ServersModel
    {
        public int id { get; set; }
        public string MachineName { get; set; }
        public string MachineDomain { get; set; }
        public string Enviroment { get; set; }
        public string Application { get; set; }
        public string ServiceLine { get; set; }
        public string Type { get; set; }
        public string Cluster { get; set; }
      

    }

     
}