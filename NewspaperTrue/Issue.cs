using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperTrue
{
    public class Issue
    {
       public int Id { get; set; }
        public DateTime PublicationDate { get; set; }
        public List<Article> Articles { get; set; }

        public Issue()
        {
            
            Articles = new List<Article>();
        }

    }
}
