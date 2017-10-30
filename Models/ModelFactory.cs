using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EzUtility.Models
{
    public class ModelFactory
    {

        public ServiceLinesModel GetServiceLines(ezServiceLine svcLines) {
             return new ServiceLinesModel()
            {
                id = svcLines.id,
                serviceLine_name = svcLines.serviceLine_name,
                description = svcLines.description
            };
        }

        public EnvironmentsModel GetEnvironment(ezEnvironment env) {

            return new EnvironmentsModel()
            {
                id = env.id,
                environment = env.environment
            };
        }

        public ServiceOfferingsModel GetServiceOfferings(Service_Offering_Base sob)
        {
            return new ServiceOfferingsModel()
            {
                id = sob.SOID,
                Service_Offering = sob.Service_Offering
            };
        }

        public ServiceLinesModelImpact GetServiceLineImpact(Service_Line_Base slb)
        {
            return new ServiceLinesModelImpact()
            {
                SLID=slb.SLID,
                Service_Line=slb.Service_Line,
                ShortName=slb.ShortName,
                SOID=(int)slb.SOID               
            };
        }
        public ApplicationsModelImpact GetApplicationsImpact(Application_Base app)
        {
            return new ApplicationsModelImpact()
            {
               AppId=app.AppId,
                Appl_name = app.Appl_name,
                Threaded =app.Threaded,
                Division = app.Division,
                SOID = app.SOID,
                SLID = app.SLID
            };
        }

        public DependentApplicationsModelImpact GetDependentApplicationsImpact(DependencyMatrix dm)
        {
            return new DependentApplicationsModelImpact()
            {
                SID = dm.SID,
                AppID = dm.AppID,
                DependentAppID = dm.DependentAppID,
                Stream = dm.Stream,
                ImpactStatment = dm.ImpactStatment,
                depApps = dm.DependentApp
            };
        }

         




        public ApplicationsModel GetApplications(ezApplication app)
        {
            return new ApplicationsModel()
            {
                id = app.id,
                Title = app.Title,
                ShortName = app.ShortName,
                ServiceCatalogId = app.ServiceCatalogId
            };
        }

        public ServersModel GetServers(ezServer ser)
        {
            return new ServersModel()
            {
                id = ser.id,
                MachineName = ser.MachineName,
                MachineDomain=ser.MachineDomain,
                Enviroment = ser.ezEnvironment.environment,
                Application=ser.ezApplication.ShortName,
                ServiceLine=ser.ezServiceLine.serviceLine_name,
                Type=ser.ezType.type,
                Cluster=ser.ezCluster.clusterName

            };
        }

       
    }
}