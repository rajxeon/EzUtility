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
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;
using System.Text;

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
        {   ViewData["Message"] = "Welcome to EzPatch";
            return View();
        }

        [HttpPost]
        public string RunPS(string filename, string first_param = "", string second_param = "", string third_param = "") {

            RunspaceConfiguration runspaceConfiguration = RunspaceConfiguration.Create();

            // create Powershell runspace
            Runspace runspace = RunspaceFactory.CreateRunspace();

            // open it
            runspace.Open();

            // create a pipeline and feed it the script text
            Pipeline pipeline = runspace.CreatePipeline();

            //string command_path = Server.MapPath("~") + @"App_Data\PS\getLog.ps1";
            string command_path = Server.MapPath("~") + @"PSScripts\"+ filename + ".ps1";
            Command myCommand = new Command(command_path);

            //-----------------------------PARAMS--------------------------------

            if (first_param.Length > 0) {
                CommandParameter testParam = new CommandParameter(first_param.Split('>')[0], first_param.Split('>')[1]);
                myCommand.Parameters.Add(testParam);
            }
            if (second_param.Length > 0)
            {
                CommandParameter testParam1 = new CommandParameter(second_param.Split('>')[0], second_param.Split('>')[1]);
                myCommand.Parameters.Add(testParam1);
            }
            if (third_param.Length > 0)
            {
                CommandParameter testParam2 = new CommandParameter(third_param.Split('>')[0], third_param.Split('>')[1]);
                myCommand.Parameters.Add(testParam2);
            }

            //-------------------------------------------------------------------

            pipeline.Commands.Add(myCommand);

            Collection<PSObject> results = pipeline.Invoke();

            runspace.Close();

            // convert the script result into a single string
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject obj in results)
            {
                stringBuilder.AppendLine(obj.ToString());
            }

            return stringBuilder.ToString();

             
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
        public string getServers(int envId,int applicationId)
        {

            var query = dbContext.ezServers.Where(c => ( c.EnvironmentID == envId && c.ApplicationID==applicationId))               .ToList()
               .Select(a => _modelFactory.GetServers(a));
            var json = JsonConvert.SerializeObject(query);
            return json;
            

        }

    }
}