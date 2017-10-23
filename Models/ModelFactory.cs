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
        
    }
}