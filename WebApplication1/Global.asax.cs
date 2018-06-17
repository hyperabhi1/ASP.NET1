using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebApplication1;

namespace WebApplication1
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            Application["TotalApplications"] = 0;
            Application["TotalActiveUsers"] = 0;
            Application["TotalUsers"] = 0;

            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown
            Application["TotalApplications"] = (int)Application["TotalApplications"] - 1;
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
        void Session_Start(object sender, EventArgs e)
        {
            //User Counts
            Application["TotalActiveUsers"] = (int)Application["TotalActiveUsers"] + 1;
            Application["TotalUsers"] = (int)Application["TotalUsers"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            //Active Users reduced by 1
            Application["TotalActiveUsers"] = (int)Application["TotalActiveUsers"] - 1;
        }
    }
}
