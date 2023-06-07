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
            int reporter = 1;
            int issue = 1;

            Article article = new Article("Title", "content", reporter, issue);
            Assert.Equal("Title", article.Title);
            Assert.Equal("content", article.Content);
            Assert.Equal(reporter, article.ReporterId);
            Assert.Equal(issue, article.IssueId);
        }
    }
}
