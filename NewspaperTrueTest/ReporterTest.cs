using NewspaperTrue;
using System.Xml.Linq;

namespace NewspaperTrueTest
{
    public class ReporterTest
    {
        [Fact]
        public void Reporter_CreateReporter_InstanceCreatedWithCorrectProperties()
        {

            Reporter reporter = new Reporter("John", "Politics");
            Assert.Equal("John", reporter.Name);
            Assert.Equal("Politics", reporter.Speciality);

        }
    }
}