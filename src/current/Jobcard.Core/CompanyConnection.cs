using System;
using System.Collections.Generic;
using System.Text;

namespace Jobcard.Core
{
    public class CompanyConnection
    {
        public string FileName { get; set; }
        public string Name { get; set; }
        public string DatabaseHost { get; set; }
        public string DatabaseServer
        {
            get
            {
                if (DatabaseHost.Contains(@"\"))
                {

                    var databaseServer = DatabaseHost.Split('\\')[0];

                    if (databaseServer.Equals(Environment.MachineName, StringComparison.OrdinalIgnoreCase))
                    {
                        return $"This computer ({databaseServer[0]})";
                    }
                    else
                    {
                        return databaseServer;
                    }
                }
                return DatabaseHost;
            }
        }
        public string DatabaseName { get; set; }
    }
}
