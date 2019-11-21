using Jobcard.Core;
using System.Collections.Generic;

namespace Jobcard.Data
{
    public interface ICompanyConnectionRepository
    {
        IEnumerable<CompanyConnection> GetAll(string path);
    }
}
