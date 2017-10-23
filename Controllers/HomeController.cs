using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNet.Identity;
using System.Diagnostics;
using EzUtility.Models;

namespace EzUtility.Controllers
{

    

    public class HomeController : Controller
    {
        public EzUtilityEntities dbContext=new EzUtilityEntities();
        public ModelFactory _modelFactory = new ModelFactory();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ez()
        {
            
            ViewData["Message"] = "Welcome to EzPatch";
            return View();
        }

        
        [HttpPost]        
        public string getServiceLine() { 
            var query = dbContext.ezServiceLines.ToList().Select(c=>_modelFactory.GetServiceLines(c));        
            var json = JsonConvert.SerializeObject(query);            
            return json;           
        }

        [HttpPost]
        public string getEnvironments()
        {
            var query = dbContext.ezEnvironments.ToList().Select(c => _modelFactory.GetEnvironment(c));
            var json = JsonConvert.SerializeObject(query);
            return json;

        }

        [HttpPost]
        public string getApplications(int serviceLineId)
        {
            var query= dbContext.ezApplications.Where(c=>c.ServiceLineId==serviceLineId)
                .ToList()
                .Select(a => _modelFactory.GetApplications(a));            
            var json = JsonConvert.SerializeObject(query);
            return json;

        }

        [HttpPost]
        public string getServers(int svcLineID, int envId)
        {
            var context = new EzUtilityEntities();
            var query = (from c in context.ezServers
                         where (c.ServiceLineID==svcLineID) 
                         &&
                         (c.EnvironmentID==envId)
                         select c);
            var json = JsonConvert.SerializeObject(query);
            return json;

        }

    }
}