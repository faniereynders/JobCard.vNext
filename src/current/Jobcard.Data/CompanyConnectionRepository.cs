using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Jobcard.Core;

namespace Jobcard.Data
{
    public class CompanyConnectionRepository : ICompanyConnectionRepository
    {
        private const string JOBCARD_FILE_EXTENSION = "*.jcc";

        public IEnumerable<CompanyConnection> GetAll(string path) =>
            Directory.GetFiles(path, JOBCARD_FILE_EXTENSION)
                .Select(file =>
                {
                    var fileContents = File.ReadAllText(file);
                    var fileLines = Regex.Split(fileContents, "\r\n");
                    return new CompanyConnection
                    {
                        Name = fileLines[0],
                        DatabaseHost = fileLines[1],
                        FileName = file,
                        DatabaseName = fileLines[2]
                    };
                });
    }
}
