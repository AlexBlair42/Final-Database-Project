using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

//This code comes from https://msdn.microsoft.com/en-us/library/jj943772.aspx#BKMK_createtheformsandaddcontrols
namespace TheatreManagerApp
{
    internal class Utility
    {
        internal static string GetConnectionString()
        {
            //Util-2 Assume failure.  
            string returnValue = null;

            //Util-3 Look for the name in the connectionStrings section.  
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["TheatreManagerApp.Properties.Settings.connString"];

            //If found, return the connection string.  
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}
