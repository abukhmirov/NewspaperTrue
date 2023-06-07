using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperTrue
{
    public class Article
    {
       public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ReporterId { get; set; }
        public int IssueId { get; set; }
        public Issue Issue { get; set; }
        public Reporter Reporter { get; set; }

        public Article(string title, string content, int reporterId, int issueId)
        {
            Title = title;
            Content = content;
            ReporterId = reporterId;
            IssueId = issueId;
        }

    }
}
