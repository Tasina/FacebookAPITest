using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookTest
{
    public class PageReactionInfo
    {
        //Total number of likes on all posts accross the page
        public int Id { get; set; }
        public long TotalLike { get; set; }
        //Total number of likes on all posts accross the page
        public long TotalLove { get; set; }
        //Total number of likes on all posts accross the page
        public long TotalWow { get; set; }
        //Total number of likes on all posts accross the page
        public long TotalHaha { get; set; }
        //Total number of likes on all posts accross the page
        public long TotalSad { get; set; }
        //Total number of likes on all posts accross the page
        public long TotalAngry { get; set; }
        //Total number of likes on all posts accross the page
        public long TotalThankful { get; set; }
        //Records the time for the current ammounts of reactions
        public DateTime DateTime { get; set; }

        public string PostId { get; set; }
    }
}
