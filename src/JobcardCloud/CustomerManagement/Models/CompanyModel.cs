using JobcardCloud.CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobcardCloud.Customers.Models
{
    class CompanyModel : CustomerModel
    {
        public string VATRegistrationNumber { get; set; }
        public string Director1_Name { get; set; }
        public string Director1_IDNumber { get; set; }
        public string Director2_Name { get; set; }
        public string Director2_IDNumber { get; set; }
        public string Director3_Name { get; set; }
        public string Director3_IDNumber { get; set; }
        public string Director4_Name { get; set; }
        public string Director4_IDNumber { get; set; }

        public string ManagerName { get; set; }
        
    }

}
