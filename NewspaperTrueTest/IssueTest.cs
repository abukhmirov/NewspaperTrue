using NewspaperTrue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperTrueTest
{
    public class IssueTest
    {
        public void Issue_Constructor_AllPropertiesAddedCorrectly()
        {
            Issue issue = new Issue(DateTime.Now);
            Assert.IsType<DateTime>(issue.PublicationDate);
        }
    }
}
