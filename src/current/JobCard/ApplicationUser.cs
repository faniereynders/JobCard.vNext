using System.Collections.Generic;

namespace JobCard
{
    public class AzureADUserDto
    {

        public string Id { get; set; }
        public string DisplayName { get; set; }
    }
    public class AzureADUserGroupsDto
    {
        public AzureADGroupDto[] Value { get; set; }


        public class AzureADGroupDto
        {
            public string Id { get; set; }
            public string DisplayName { get; set; }
        }
    }
    

    //public class Organization
    //{
    //    public string Id { get; set; }
    //    public string DisplayName { get; set; }
    //}
}