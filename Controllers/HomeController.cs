using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNet.Identity;

namespace EzUtility.Controllers
{

    

    public class HomeController : Controller
    {
        public EzUtilityEntities dbContext=new EzUtilityEntities();
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ez()
        {
            
            ViewData["Message"] = "Welcome to EzPatch";
            return View();
        }

        

        public string getServiceLine() {            
            var context = new EzUtilityEntities(); 
            var query =(from c in context.ServiceLines select c);
            var json = JsonConvert.SerializeObject(query);
            return json+ User.Identity.GetUserId();
            
        }

    }
}