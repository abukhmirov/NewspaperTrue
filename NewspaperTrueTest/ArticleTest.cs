using NewspaperTrue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperTrueTest
{
    public class ArticleTest
    {
        public void Article_Constructor_PropertiesAddedCorrectly()
        {
            Reporter reporter = new Reporter("John Doe", "Politics");
            Issue issue = new Issue(DateTime.Now);
            Article article = new Article("Title", "content", reporter, issue);
            Assert.Equal("Title", article.Title);
            Assert.Equal("content", article.Content);
            Assert.Equal(reporter, article.Reporter);
            Assert.Equal(issue, article.Issue);
        }
    }
}
